using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToyBuilder : MonoBehaviour 
{
    public GameObject bike, doll, truck;
    Button bikeButton, dollButton, truckButton;

    void Start()
    {
        bikeButton = bike.gameObject.GetComponent<Button>();
        dollButton = doll.gameObject.GetComponent<Button>();
        truckButton = truck.gameObject.GetComponent<Button>();
    }

    public void AddBike()
    {
        GameController.controller.IncrementToyCount("Bike");
        TurnButtonOff("Bike");
    }

    public void AddDoll()
    {
        GameController.controller.IncrementToyCount("Doll");
        TurnButtonOff("Doll");
    }

    public void AddTruck()
    {
        GameController.controller.IncrementToyCount("Truck");
        TurnButtonOff("Truck");
    }

    public void AddBlocks(){}

    public void TurnButtonOff(string toy)
    {
        switch (toy)
        {
            case "Bike": bikeButton.interactable = false; break;
            case "Doll": dollButton.interactable = false; break;
            case "Truck": truckButton.interactable = false; break;
            default: break;
        }
    }

    public void TurnButtonOn(string toy)
    {
        switch (toy)
        {
            case "Bike": bikeButton.interactable = true; break;
            case "Doll": dollButton.interactable = true; break;
            case "Truck": truckButton.interactable = true; break;
            default: break;
        }
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToyCount : MonoBehaviour 
{
    Text text;

    void Start ()
    {
        text = gameObject.GetComponent<Text>();
    }

	void Update () 
    {
	    if (gameObject.name == "Bike")
        {
            text.text = "Bikes: " + GameController.controller.NumberOfBikes;
        }
        else if (gameObject.name == "Doll")
        {
            text.text = "Dolls: " + GameController.controller.NumberOfDolls;
        }
        else if (gameObject.name == "Truck")
        {
            text.text = "Trucks: " + GameController.controller.NumberOfTrucks;
        }
        else if (gameObject.name == "Block"){}
	}
}

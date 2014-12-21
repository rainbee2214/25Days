using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
    public static GameController controller;

    int numberOfBikes = 0;
    int numberOfDolls = 0;
    int numberOfTrucks = 0;
    int numberOfBlocks = 0;

    int numberOfCandy1 = 0;
    int numberOfCandy2 = 0;
    int numberOfCandy3 = 0;    
    
    public int NumberOfBikes
    {
        get { return numberOfBikes; }
        set { numberOfBikes += value; }
    }
    public int NumberOfDolls
    {
        get { return numberOfDolls; }
        set { numberOfDolls += value; }
    }
    public int NumberOfTrucks
    {
        get { return numberOfTrucks; }
        set { numberOfTrucks += value; }
    }
    public int NumberOfBlocks
    {
        get { return numberOfBlocks; }
        set { numberOfBlocks += value; }
    }

    void Awake()
    {
        if (controller == null)
        {
            DontDestroyOnLoad(gameObject);
            controller = this;
        }
        else if (controller != this)
        {
            Destroy(gameObject);
        }
    }

    public void IncrementToyCount(string toy)
    {
        switch(toy)
        {
            case "Bike": numberOfBikes++; break;
            case "Doll": numberOfDolls++; break;
            case "Truck": numberOfTrucks++; break;
            case "Blocks": numberOfBlocks++; break;
            default: break;
        }
    }
}

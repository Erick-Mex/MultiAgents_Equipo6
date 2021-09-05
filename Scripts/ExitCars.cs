using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCars : MonoBehaviour
{
    void OnTriggerExit(Collider cars)
    {
        switch (cars.tag)
        {
            case "North":
                EntryCars.cars.setNorth(EntryCars.cars.getNorth()-1);
                break;
            case "West":
                EntryCars.cars.setWest(EntryCars.cars.getWest()-1);
                break;
            case "South":
                EntryCars.cars.setSouth(EntryCars.cars.getSouth()-1);
                break;
            default:
                EntryCars.cars.setEast(EntryCars.cars.getEast()-1);
                break;
        }
    }
}

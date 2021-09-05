using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    // [0]south [1]east [2]north [3]west 

    public static GameObject[] lightTraffic;
    public GameObject[] colliderIntersection;
    private int[] number_of_Cars = new int[4];

    void Start()
    {

        if (lightTraffic == null) lightTraffic = GameObject.FindGameObjectsWithTag("Lights");

    }

    //Que es esta atrocidad aiuda... Es feo de ver
    void Update()
    {
        UpdateNumberCars();

        if(number_of_Cars[0] == 0 && number_of_Cars[1] == 0 && number_of_Cars[2] == 0 && number_of_Cars[3] == 0) 
        {
            lightTraffic[0].GetComponent<Light>().color = Color.red;
            lightTraffic[1].GetComponent<Light>().color = Color.red;
            lightTraffic[2].GetComponent<Light>().color = Color.red;
            lightTraffic[3].GetComponent<Light>().color = Color.red;
            
            colliderIntersection[0].SetActive(true);
            colliderIntersection[1].SetActive(true);
            colliderIntersection[2].SetActive(true);
            colliderIntersection[3].SetActive(true);
        }
        else if (number_of_Cars[0] > number_of_Cars[1] && number_of_Cars[0] > number_of_Cars[2] && number_of_Cars[0] > number_of_Cars[3]) 
        {
            lightTraffic[0].GetComponent<Light>().color = Color.green;
            lightTraffic[1].GetComponent<Light>().color = Color.red;
            lightTraffic[2].GetComponent<Light>().color = Color.red;
            lightTraffic[3].GetComponent<Light>().color = Color.red;
            
            colliderIntersection[0].SetActive(false);
            colliderIntersection[1].SetActive(true);
            colliderIntersection[2].SetActive(true);
            colliderIntersection[3].SetActive(true);
        }
        else if (number_of_Cars[1] > number_of_Cars[0] && number_of_Cars[1] > number_of_Cars[2] && number_of_Cars[1] > number_of_Cars[3]) 
        {
            lightTraffic[1].GetComponent<Light>().color = Color.green;
            lightTraffic[0].GetComponent<Light>().color = Color.red;
            lightTraffic[2].GetComponent<Light>().color = Color.red;
            lightTraffic[3].GetComponent<Light>().color = Color.red;
            
            colliderIntersection[1].SetActive(false);
            colliderIntersection[0].SetActive(true);
            colliderIntersection[2].SetActive(true);
            colliderIntersection[3].SetActive(true);
        }
        else if (number_of_Cars[2] > number_of_Cars[0] && number_of_Cars[2] > number_of_Cars[1] && number_of_Cars[2] > number_of_Cars[3]) 
        {
            lightTraffic[2].GetComponent<Light>().color = Color.green;
            lightTraffic[0].GetComponent<Light>().color = Color.red;
            lightTraffic[1].GetComponent<Light>().color = Color.red;
            lightTraffic[3].GetComponent<Light>().color = Color.red;
            
            colliderIntersection[2].SetActive(false);
            colliderIntersection[0].SetActive(true);
            colliderIntersection[1].SetActive(true);
            colliderIntersection[3].SetActive(true);
        }
        else 
        {
            lightTraffic[3].GetComponent<Light>().color = Color.green;
            lightTraffic[0].GetComponent<Light>().color = Color.red;
            lightTraffic[1].GetComponent<Light>().color = Color.red;
            lightTraffic[2].GetComponent<Light>().color = Color.red;
            
            colliderIntersection[3].SetActive(false);
            colliderIntersection[0].SetActive(true);
            colliderIntersection[1].SetActive(true);
            colliderIntersection[2].SetActive(true);
        }


    }

    void UpdateNumberCars()
    {
        number_of_Cars[0] = EntryCars.cars.getSouth();
        number_of_Cars[1] = EntryCars.cars.getEast();
        number_of_Cars[2] = EntryCars.cars.getNorth();
        number_of_Cars[3] = EntryCars.cars.getWest();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPushLights : MonoBehaviour
{
    // [0]south [1]east [2]north [3]west 
    public static GameObject[] lightTraffic;
    public GameObject[] colliderIntersection;

    void Start()
    {

        if (lightTraffic == null) lightTraffic = GameObject.FindGameObjectsWithTag("Lights");

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            lightTraffic[0].GetComponent<Light>().color = Color.red;
            lightTraffic[1].GetComponent<Light>().color = Color.red;
            lightTraffic[2].GetComponent<Light>().color = Color.red;
            lightTraffic[3].GetComponent<Light>().color = Color.green;

            colliderIntersection[0].SetActive(true);
            colliderIntersection[1].SetActive(true);
            colliderIntersection[2].SetActive(true);
            colliderIntersection[3].SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            lightTraffic[0].GetComponent<Light>().color = Color.red;
            lightTraffic[1].GetComponent<Light>().color = Color.red;
            lightTraffic[2].GetComponent<Light>().color = Color.green;
            lightTraffic[3].GetComponent<Light>().color = Color.red;

            colliderIntersection[0].SetActive(true);
            colliderIntersection[1].SetActive(true);
            colliderIntersection[2].SetActive(false);
            colliderIntersection[3].SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.S))
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
        else if (Input.GetKeyDown(KeyCode.D))
        {
            lightTraffic[0].GetComponent<Light>().color = Color.red;
            lightTraffic[1].GetComponent<Light>().color = Color.green;
            lightTraffic[2].GetComponent<Light>().color = Color.red;
            lightTraffic[3].GetComponent<Light>().color = Color.red;

            colliderIntersection[0].SetActive(true);
            colliderIntersection[1].SetActive(false);
            colliderIntersection[2].SetActive(true);
            colliderIntersection[3].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.C)) {
            if (InstanceCar.ic.getWaitTime() <= 1) {
                InstanceCar.ic.setWaitTime(5);
            } else {
                InstanceCar.ic.setWaitTime(InstanceCar.ic.getWaitTime() - 1);
            }
        }
    }
}

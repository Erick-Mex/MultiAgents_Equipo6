using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceCar : MonoBehaviour
{
    private List<KeyValuePair<Vector3, Quaternion>> carInfo = new List<KeyValuePair<Vector3, Quaternion>>();
    private static Object[] prefabs;
    private GameObject car;
    [SerializeField] private int cycles = 0;
    public static InstanceCar ic;
    [SerializeField] private int waitTime = 5;

    void Awake()
    {
        ic = this;
    }

    void Start()
    {
        carInfo.Add(new KeyValuePair<Vector3, Quaternion>(new Vector3(-15.2f, 0, -38), Quaternion.Euler(0, 0, 0)));
        carInfo.Add(new KeyValuePair<Vector3, Quaternion>(new Vector3(15.2f, 0, 0.2f), Quaternion.Euler(0, 270, 0)));
        carInfo.Add(new KeyValuePair<Vector3, Quaternion>(new Vector3(-21.8f, 0, 31), Quaternion.Euler(0, 180, 0)));
        carInfo.Add(new KeyValuePair<Vector3, Quaternion>(new Vector3(-53, 0, -6.5f), Quaternion.Euler(0, 90, 0)));

        carInfo.Add(new KeyValuePair<Vector3, Quaternion>(new Vector3(-17.3f, 0, -38), Quaternion.Euler(0, 0, 0)));
        carInfo.Add(new KeyValuePair<Vector3, Quaternion>(new Vector3(15.2f, 0, -2), Quaternion.Euler(0, 270, 0)));
        carInfo.Add(new KeyValuePair<Vector3, Quaternion>(new Vector3(-19.5f, 0, 31), Quaternion.Euler(0, 180, 0)));
        carInfo.Add(new KeyValuePair<Vector3, Quaternion>(new Vector3(-53, 0, -4.3f), Quaternion.Euler(0, 90, 0)));

        prefabs = Resources.LoadAll("Prefabs");

        StartCoroutine(newCar());
    }

    public int getWaitTime()
    {
        return waitTime;
    }

    public void setWaitTime(int value)
    {
        waitTime = value;
    }

    IEnumerator newCar()
    {
        for (int i = 0; i < cycles; i++)
        {
            int index_car = Random.Range(0, prefabs.Length);
            int index_location = Random.Range(0, carInfo.Count);
            /* if(canInstance.canSpawn)
            {
                car = Instantiate(prefabs[index_car], carInfo[index_location].Key, carInfo[index_location].Value) as GameObject;
                AssignTag(car);
            } */
            car = Instantiate(prefabs[index_car], carInfo[index_location].Key, carInfo[index_location].Value) as GameObject;
            AssignTag(car);
            yield return new WaitForSeconds(getWaitTime());
        }
        yield return null;
    }

    void AssignTag(GameObject car)
    {
        if (car.transform.position == new Vector3(-15.2f, 0, -38) || car.transform.position == new Vector3(-17.3f, 0, -38))
        {
            car.tag = "South";
        }
        else if ((car.transform.position == new Vector3(15.2f, 0, 0.2f) || car.transform.position == new Vector3(15.2f, 0, -2)))
        {
            car.tag = "East";
        }
        else if ((car.transform.position == new Vector3(-21.8f, 0, 31) || car.transform.position == new Vector3(-19.5f, 0, 31)))
        {
            car.tag = "North";
        }
        else
        {
            car.tag = "West";
        }
    }
}

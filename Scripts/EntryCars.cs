using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryCars : MonoBehaviour
{
    public static EntryCars cars; //Instancia del script
    private GameObject exitCars;
    //Numero de carros en su respectiva carretera
    [SerializeField]private int southCars = 0;
    [SerializeField]private int EastCars = 0;
    [SerializeField]private int NorthCars = 0;
    [SerializeField]private int WestCars = 0;

    void Awake()
    {
        cars = this;
    }

    void Start()
    {
        exitCars = GameObject.Find("TriggerExit");
        foreach(Transform child in transform)
        {
            child.gameObject.AddComponent<CountCars>();
        }
        
        foreach(Transform child in exitCars.transform)
        {
            child.gameObject.AddComponent<ExitCars>();
        }
    }

    public int getNorth()
    {
        return NorthCars;
    }

    public int getWest()
    {
        return WestCars;
    }

    public int getSouth()
    {
        return southCars;
    }

    public int getEast()
    {
        return EastCars;
    }

    public void setNorth(int value)
    {
        NorthCars = value;
    }

    public void setWest(int value)
    {
        WestCars = value;
    }

    public void setSouth(int value)
    {
        southCars = value;
    }

    public void setEast(int value)
    {
        EastCars = value;
    }
}

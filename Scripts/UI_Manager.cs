using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public TextMeshProUGUI countCars;
    public TextMeshProUGUI time;
    public TextMeshProUGUI spawnTime;
    private float timeElapsed = 0f;

    void Update()
    {
        countCars.text = "Cantidad de Autos por avanzar: " + TotalCars();
        time.text = "Tiempo: " + timeElapsed.ToString("F3");
        spawnTime.text = "Tiempo de espera entre aparición de autos: " + SpawnCarsTime();
        timeElapsed += Time.deltaTime;
    }

    int TotalCars()
    {
        int total = EntryCars.cars.getNorth() + EntryCars.cars.getWest() + EntryCars.cars.getSouth() + EntryCars.cars.getEast();
        return total;
    }

    int SpawnCarsTime()
    {
        int carsTime = InstanceCar.ic.getWaitTime();
        return carsTime;
    }
}

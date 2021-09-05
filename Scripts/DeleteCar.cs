using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCar : MonoBehaviour
{
    void OnTriggerEnter(Collider car) {
        Destroy(car.gameObject);
    }
}

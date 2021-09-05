using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canInstance : MonoBehaviour
{
    public static bool canSpawn = true;

    void OnTriggerEnter(Collider other)
    {
        canSpawn = !canSpawn;
    }

    void OnTriggerExit(Collider other)
    {
        canSpawn = !canSpawn;
    }
}

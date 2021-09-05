using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoLights : MonoBehaviour
{
    public Behaviour Light_Container;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            //Desabilita o activa el canvas
            Light_Container.enabled = !Light_Container.enabled;

        }
    }
}

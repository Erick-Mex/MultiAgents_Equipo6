using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasHide_Show : MonoBehaviour
{
    //variable en la que se almacena el canvas
    public Behaviour Inventory_Canvas;

    // Update is called once per frame
    void Update()
    {
        //Cuando sea que precione TAB se llama la variable
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            //Desabilita o activa el canvas
            Inventory_Canvas.enabled = !Inventory_Canvas.enabled;

        }
    }
}

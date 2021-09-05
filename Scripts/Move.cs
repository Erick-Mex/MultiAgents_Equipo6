using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Lights light_states;
    private GameObject[] lightTraffic;
    private Rigidbody rb;
    private Vector3 myView;
    private LayerMask triggers;
    
    private float speed = 20f;
    
    void Start()
    {
        if (lightTraffic == null) lightTraffic = GameObject.FindGameObjectsWithTag("Lights"); // Lista de los semaforos
        rb = GetComponent<Rigidbody>();
        myView = myLocalView();
        triggers = LayerMask.GetMask("Default");
    }

    void Update()
    {
        //Destruye el carro llegando al fin del mundo
        if(transform.position.y < -0.5f) Destroy(gameObject);
    }

    void FixedUpdate()
    {
        //Detectar si hay una colision en frente
        if(Physics.Raycast(transform.position + new Vector3(0, 0.5f, 0), myView, 4f, triggers))
        {
            //Detener el vehiculo
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
        else
        {
            //Mover el carro hasta la interseccion segun su respectivo lado
            if(gameObject.tag == "South")
            {
                rb.velocity = Vector3.forward * speed;
            }
            else if(gameObject.tag == "East")
            {
                rb.velocity = Vector3.left * speed;
            }
            else if(gameObject.tag == "North")
            {
                rb.velocity = Vector3.back * speed;
            }
            else if(gameObject.tag == "West")
            {
                rb.velocity = Vector3.right * speed;
            }
        }
    }

    //Asigna un tag segun la posicion de spawn
    Vector3 myLocalView()
    {
        switch (gameObject.tag)
        {
            case "South":
                return Vector3.forward;
            case "East":
                return Vector3.left;
            case "North":
                return Vector3.back;
            default:
                return Vector3.right;
        }
    }
}

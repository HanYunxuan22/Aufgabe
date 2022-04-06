using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public Rigidbody Rb;
    public float forwardForce = 100f; // Einstellung Druckkraft
    public float sidewayForce = 500f; //Einstellung Querkraft


    void FixedUpdate()
    {
        Rb.AddForce(0, 0, forwardForce * Time.deltaTime); 



        if (Input.GetKey("d")) // rechts
        {
            Rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }
      if(Input.GetKey("a")) //links
        {
            Rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }
          
          
    }
}


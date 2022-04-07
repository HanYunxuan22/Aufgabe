using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public Rigidbody Rb2;
    public float liftForce = 100f; // Einstellung Druckkraft
   


    void Update()
    {
        if (Input.GetKey("1"))
        {
            Rb2.AddForce(0, liftForce * Time.deltaTime, 0);

            Quaternion rotation = Quaternion.AngleAxis(90f, Vector3.right);

            gameObject.transform.rotation = rotation;
        }
        if (Input.GetKey("2"))
        {
            Rb2.AddForce(0, -liftForce * Time.deltaTime, 0);
            Quaternion rotation = Quaternion.AngleAxis(90f, Vector3.forward);

            gameObject.transform.rotation = rotation;
        }

    }
    

    

    }

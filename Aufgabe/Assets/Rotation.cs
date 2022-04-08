using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform Cube_Parent;  // Revolution
    public Transform Sphere_Children; //Selbst rotation
   

    
    void Update()
    {
        Sphere_Children.Rotate(Vector3.up, 20f * Time.deltaTime, Space.Self);  // Vector3.up +y (0,1,0), Geschwindigkeit, eigene Koordinatesystem
        Sphere_Children.RotateAround(Cube_Parent.position, Cube_Parent.up, 20f * Time.deltaTime); 
    }
}

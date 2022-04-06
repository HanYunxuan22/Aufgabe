using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform Cube_Parent;
    public Transform Sphere_Children;


    // Update is called once per frame
    void Update()
    {
        Sphere_Children.Rotate(Vector3.up, 20 * Time.deltaTime, Space.Self);
        Sphere_Children.RotateAround(Cube_Parent.position, Cube_Parent.up, 20f * Time.deltaTime);
    }
}

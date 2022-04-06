using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform CubeMove;
    public Vector3 distance;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(CubeMove.position); // Checken der Bewegung von Cube

        transform.position = CubeMove.position + distance; // Kamerapos = Cubeposition + Abstand zw. den Beiden

    }
}

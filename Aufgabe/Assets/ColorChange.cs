using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    RaycastHit hit;
    public LayerMask clickableLayer;
    public GameObject Obj;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 50, clickableLayer.value))
            {
                //Debug.Log(hit.collider.gameObject.name);
                if (Obj.tag == "Cube")
                    Obj.GetComponent<Renderer>().material.color = Color.blue;
            }
        }
    }
}

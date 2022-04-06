using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    RaycastHit hit;// out typ und Rueckgabe von Kollisionsdetektion 
    public LayerMask clickableLayer; 
    public LayerMask clickableLayer2;
    public GameObject Obj;  
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Linke Maustaste 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //ray ist eine Strahlung zum Kollisionsdetektion aus Kamera zur Parameter 
            if (Physics.Raycast(ray, out hit, 50, clickableLayer.value)) 
            {
                //Debug.Log(hit.collider.gameObject.name);// zeigt welches Objekt die Maus klickt 
                if (Obj.tag == "ChangeColor") // Faberaenderung durch "Tag"_Identifizieren
                    Obj.GetComponent<Renderer>().material.color = Color.blue;
            }
            if (Physics.Raycast(ray, out hit, 50, clickableLayer2.value))
            {

                if (Obj.tag == "ChangeColor")
                    Obj.GetComponent<Renderer>().material.color = Color.red;
            } 

            }
    }
}

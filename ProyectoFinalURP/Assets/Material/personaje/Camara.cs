using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    float RotacionVertical;
    public float velocidad;

    void Start()
    {
        
    }

    
    void Update()
    {
        RotacionVertical = Input.GetAxis("Mouse Y");
        Vector3 RotacionX = new Vector3(RotacionVertical, 0, 0);
        transform.Rotate(RotacionX * velocidad);
    }
}

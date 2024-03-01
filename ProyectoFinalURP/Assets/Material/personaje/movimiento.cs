using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    float MoverVertical;
    float MoverHorizontal;
    float RotacionHorizontal;
    public float velocidadR;
    public float velocidad;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mover();
    }

    void mover()
    {
        MoverHorizontal = (Input.GetAxis("Horizontal"));
        MoverVertical = (Input.GetAxis("Vertical"));
        RotacionHorizontal = Input.GetAxis("Mouse X");

        Vector3 Movimiento = new Vector3(MoverHorizontal, 0, MoverVertical);
        Vector3 RotacionX = new Vector3(0, RotacionHorizontal, 0);

        transform.Translate(Movimiento * velocidad);
        transform.Rotate(RotacionX *velocidadR);
    }
}
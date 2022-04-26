using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repueratorio2 : MonoBehaviour
{
    public string Moneda;
    public float monto_a_convertir;
    float montofinal;

    void Start()
    {
        if (Moneda == "D" && monto_a_convertir > 1000)
        {
            montofinal = (monto_a_convertir * 0.0087f);
            Debug.Log(montofinal);
        }
        else if (Moneda == "E" && monto_a_convertir > 1000)
        {
            montofinal = (monto_a_convertir * 0.0082f);
            Debug.Log(montofinal);
        }
        else if (Moneda == "R" && monto_a_convertir > 1000)
        {
            montofinal = (monto_a_convertir * 0.043f);
            Debug.Log(montofinal);
        }
        else if (monto_a_convertir < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

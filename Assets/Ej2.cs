using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    public int Producto1;
    public int Producto2;
    public int Producto3;
    public int Dinero;

    void Start()
    {
        int total = Producto1 + Producto2 + Producto3;
        if (Dinero < Producto1 + Producto2 + Producto3)
        {
            Debug.Log("No tienes dinero suficiente, te faltan " + (Dinero - total)+"$");
        }
        else if (Dinero > Producto1 + Producto2 + Producto3)
        {
            Debug.Log("Te sobran " + (Dinero - total)+"$");
        }
        else
        {
            Debug.Log("Tenes la cantidad de dinero justa");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

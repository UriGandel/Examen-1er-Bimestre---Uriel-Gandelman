using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaDeTaxis : MonoBehaviour
{
    public int cantidadUnidades;
    public int cantidadDiasTrabajados;

    float precioCombustible = 130;
    float cantidadLitrosUnidadDia = 90 / 15;

    float resultadoPrecio;

    // Start is called before the first frame update
    void Start()
    {
        float litrosTotales = (cantidadLitrosUnidadDia * cantidadUnidades) * cantidadDiasTrabajados;
        if (cantidadDiasTrabajados < 5 || cantidadUnidades < 1)
        {
            Debug.Log("Error, los datos ingresados no son validos");
            return;
        }
        else if(litrosTotales > 100 )
        {
            float precioCombustibleDescuento = precioCombustible - (precioCombustible * 0.20f);
            resultadoPrecio = litrosTotales * precioCombustibleDescuento;
            Debug.Log("Una flota de " + cantidadUnidades + " unidades trabajando durante " + cantidadDiasTrabajados + " días implicará un gasto de " + resultadoPrecio + " pesos en concepto de combustible");
        }
        else
        {
            resultadoPrecio = litrosTotales * precioCombustible;
            Debug.Log("Una flota de " + cantidadUnidades + " unidades trabajando durante " + cantidadDiasTrabajados + " días implicará un gasto de " + resultadoPrecio + " pesos en concepto de combustible");
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

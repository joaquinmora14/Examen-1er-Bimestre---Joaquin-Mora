using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaDeTaxis : MonoBehaviour
{
    public int cantididadDeUnidades;
    public int diasTrabajados;
    int litroDeCombustible = 130;
    int litrosDeCombustibleUsadoCadaDia = 6;
    float descuentoConvenio = 0.8f;
    int cantidadDeLitrosDescuento = 100;
    float preciofinal;
    float precioFinalDescuento;
    float dineroAhorrado;
    float numeroDescuento = 0.2f;
    int cantidadMinimaDeDias = 5;
    int cantidadMinimaDeUnidades = 1;

    // Start is called before the first frame update
    void Start()
    {
        if (cantididadDeUnidades < 1 || diasTrabajados < 5)
        {
            Debug.Log("La cantidad ingresada no es valida, el minimo de dias es de 5 y la minima cantidad de unidades es 1");
            return;
        }

        preciofinal = cantididadDeUnidades * diasTrabajados * litroDeCombustible * litrosDeCombustibleUsadoCadaDia;
        if (litrosDeCombustibleUsadoCadaDia * cantididadDeUnidades * diasTrabajados > 100)
        {
            precioFinalDescuento = preciofinal * descuentoConvenio;
            dineroAhorrado = preciofinal * numeroDescuento;
            Debug.Log("Una flota de " + cantididadDeUnidades + " unidades trabajando durante " + diasTrabajados + " días implicará un gasto de" + precioFinalDescuento + " pesos aplicando el descuento en concepto de combustible.");
            Debug.Log("Por haber comprado mas de 100 litros, han ahorrado una cantidad de " + dineroAhorrado + " pesos.");
        }
        else if(litrosDeCombustibleUsadoCadaDia * cantididadDeUnidades * diasTrabajados < 100)
        Debug.Log("Una flota de " + cantididadDeUnidades + " unidades trabajando durante " + diasTrabajados + " días implicará un gasto de" + preciofinal + " pesos en concepto de combustible.");


       
    }
      
    // Update is called once per frame
    void Update()
    {
        
    }
}

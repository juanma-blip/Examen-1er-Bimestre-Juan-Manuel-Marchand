using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej : MonoBehaviour

{
    public int espectadoresP;
    public int espectadoresC;
    int campo = 20400;
    int platea = 16200;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hemos recaudado " + espectadoresC * 1200 + "pesos por las entradas en el campo y " + espectadoresP * 2000 + "pesos con las entradas de platea, en total, "+(espectadoresC*1200+espectadoresP*2000)+"pesos.");
        if (espectadoresP < 0 || espectadoresP > platea)
        {
            Debug.Log("error");
        }
        else if (espectadoresC < 0 || espectadoresC > campo)
        {
            Debug.Log("error");
        }
        else {

            if (campo == espectadoresC)
            {
                Debug.Log("campo SOLD OUT");

            }
            else if (campo > espectadoresC)
            {
                Debug.Log("quedan" + (campo - espectadoresC) + "vacantes para el campo");

            }
            if (platea == espectadoresP)
            {
                Debug.Log("platea SOLD OUT");

            }
            else if (platea > espectadoresP)
            {
                Debug.Log("quedan" + (platea - espectadoresP) + "vacantes para la platea");

            }

            if (espectadoresC + espectadoresP >= (campo + platea) / 2)
            {
                Debug.Log("Fue un exitoo!!");

            }
            else
            {
                Debug.Log("debemos mejorar la convivencia");
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}

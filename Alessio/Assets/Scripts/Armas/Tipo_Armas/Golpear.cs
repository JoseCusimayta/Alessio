using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpear : MonoBehaviour { 


    #region Variables
    public static int Daño_Golpe = 1;
    public static string tipoArma = "Golpear";
    #endregion

    #region Start & Update
    void Start()
    {
        Invoke("Destruir", 0.1f);
    }
    #endregion

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rufianes")
        {
            #region Accion para Alessio si el objetivo es un rufian
            RufianesAI rufianesAI = other.gameObject.GetComponent<RufianesAI>();  //Instanciamos la clase RufianesAI            
            rufianesAI.Vida_Rufianes = rufianesAI.Vida_Rufianes - Daño_Golpe;   //Se resta la vida del rufian - el daño de la pistola
            if (rufianesAI.Vida_Rufianes <= 0)
            {
                rufianesAI.morir();
                Record.Score++; //Aumentamos en 1 el record
                rufianesAI.Nuevo_Rufian();
            }
            Destruir();
            #endregion
        }
    }

    #region Funciones
    public string getGolpear()
    {
        return tipoArma;
    }
    void Destruir()
    {
        Destroy(gameObject);
    }
    #endregion
    
}

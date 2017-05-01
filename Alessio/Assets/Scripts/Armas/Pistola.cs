using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistola : MonoBehaviour{

    #region Variables
    public GameObject Alessio;
    public Transform Empty_Alessio;
    public static int Daño_Pistola=3;
    #endregion

    //public Pistola(GameObject Al, Transform t)
    //{
    //    Alessio = Al;
    //    Empty_Alessio = t;
    //}
    //public void ejecutarArma(Collider other)
    //{
    //    transform.position = Empty_Alessio.position; //La pistola toma la posición del objeto vacío
    //    transform.parent = Alessio.transform; //La pistola se convierte en hijo de Alessio
    //    Disparar disparar = (Disparar)other.gameObject.GetComponent("Disparar"); //Se instancia la clase Disparar
    //    disparar.Arma = "Pistola"; //Se cambia el nombre del arma a "Pistola"
    //}

    //void OnTriggerEnter(Collider other)
    //{
    //    transform.position = Empty_Alessio.position; //La pistola toma la posición del objeto vacío
    //    transform.parent = Alessio.transform; //La pistola se convierte en hijo de Alessio
    //    Disparar disparar = (Disparar)other.gameObject.GetComponent("Disparar"); //Se instancia la clase Disparar
    //    disparar.Arma = "Pistola"; //Se cambia el nombre del arma a "Pistola"
    //}
}

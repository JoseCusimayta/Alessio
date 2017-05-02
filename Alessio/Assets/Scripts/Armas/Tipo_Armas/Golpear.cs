using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpear : MonoBehaviour { 


    #region Variables
    public static int Daño_Golpe = 1;
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
            RufianesAI rufianesAI = (RufianesAI)other.gameObject.GetComponent("RufianesAI");//Instanciamos la clase RufianesAI            
            rufianesAI.Vida_Rufianes = rufianesAI.Vida_Rufianes - Daño_Golpe; //Se resta la vida del rufian - el daño de la pistola
            if (rufianesAI.Vida_Rufianes <= 0)
            {
                //Destroy(other.gameObject); //Destruir al rufian
                rufianesAI.morir();
                Record.Score++; //Aumentamos en 1 el record
                rufianesAI.Nuevo_Rufian();
            }
            Destroy(gameObject); 
            #endregion
        }
    }

    #region Funcioes
    void Destruir()
    {
        Destroy(gameObject);
    }
#endregion

    #region Codigo anterior
    /*
    //constructor de la clase

    private bool golpe = false;
    public string Tipo_Arma;

    public Golpear(bool indicador)
    {
        golpe = indicador;
    }

    public void setGolpe(bool g)
    {
        golpe = g;
    }
    public bool getGolpe()
    { return golpe; }


    public void AtaqueGolpe()
    {
        if (Input.GetMouseButtonDown(0)) //Al hacer clic derecho...
        {
            if (Tipo_Arma == "Golpe") //Se obtiene el tipo de Arma...
            {

               // Instantiate(Prefab_Bala, Empty_Alessio.position, Quaternion.identity); //y se crea el objeto dependiendo del arma, en este caso, una bala
            }
        }
        /*
        bool keyGolpe = Input.GetKeyDown(KeyCode.N);

        if (keyGolpe)
        {
            golpe = true;
        }
        //if (keyGolpe == false)
        //{
        //    golpe = false;
        //}
        Debug.Log("Golpe actual: " + golpe);
}*/
    #endregion
}

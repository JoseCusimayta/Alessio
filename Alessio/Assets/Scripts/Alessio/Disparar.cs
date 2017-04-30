using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{

    #region Variables
    public GameObject Prefab_Bala;
    public Transform Empty_Alessio;
    public string Arma;
    #endregion

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _Disparar();

    }

    #region Funciones
    void _Disparar()
    {
        if (Input.GetMouseButtonDown(0)) //Al hacer clic derecho...
        {
            if (Arma == "Pistola") //Se obtiene el tipo de Arma...
            {
                Instantiate(Prefab_Bala, Empty_Alessio.position, Quaternion.identity); //y se crea el objeto dependiendo del arma, en este caso, una bala
            }
        }
    }
    #endregion

}
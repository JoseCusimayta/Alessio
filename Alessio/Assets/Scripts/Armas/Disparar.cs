using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{

    #region Variables
    public GameObject Prefab_Bala;
    public Transform Empty_Alessio;
    public string Tipo_Arma;
    #endregion

    #region Constructor
    public Disparar(GameObject Prefab_Bala, Transform Empty_Alessio, string Tipo_Arma)
    {
        this.Prefab_Bala = Prefab_Bala;
        this.Empty_Alessio = Empty_Alessio;
        this.Tipo_Arma = Tipo_Arma;
    }
    #endregion  

    #region Start & Update
    void Update()
    {
        _Disparar();

    }

    #endregion

    #region Funciones
    public void _Disparar()
    {
        Instantiate(Prefab_Bala, Empty_Alessio.position, Quaternion.identity); //y se crea el objeto dependiendo del arma, en este caso, una bala
    }
    #endregion

}
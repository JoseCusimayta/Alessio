﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque_Alessio : MonoBehaviour
{

    #region Variables
    public string Tipo_Arma;
    GameObject Prefab_Bala, Prefab_Golpe;
    Transform Empty_Alessio;
    Disparar disparar;
    float Intervalo_Ataque=0;
    #endregion

    #region Start & Update
    void Start()
    {
        disparar = new Disparar(Prefab_Bala, Empty_Alessio, Tipo_Arma);
    }

    // Update is called once per frame
    void Update()
    {
        Atacar();
    }
    #endregion

    #region Funciones
    public void setAtaque_Alessio(GameObject Prefab_Bala, GameObject Prefab_Golpe, Transform Empty_Alessio, string Tipo_Arma)
    {
        this.Prefab_Bala = Prefab_Bala;
        this.Empty_Alessio = Empty_Alessio;
        this.Tipo_Arma = Tipo_Arma;
        this.Prefab_Golpe = Prefab_Golpe;
    }

    public void Atacar()
    {
        if (Input.GetMouseButtonDown(0)) //Al hacer clic derecho...
        {
            Intervalo_Ataque -= Time.deltaTime;
            if (Intervalo_Ataque <= 0)
            {
                if (Tipo_Arma == "Pistola") //Se obtiene el tipo de Arma...
                {
                    Instantiate(Prefab_Bala, Empty_Alessio.position, Empty_Alessio.rotation); //y se crea el objeto dependiendo del arma, en este caso, una bala
                }
                else if (Tipo_Arma == "Golpear")
                {
                    Instantiate(Prefab_Golpe, Empty_Alessio.position, Empty_Alessio.rotation, Empty_Alessio.parent);
                }
                Intervalo_Ataque = 0.02f;
            }

        }
    }
    #endregion
}
﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alessio : MonoBehaviour {
    
    #region Variables
    public float Velocidad_EjeX = 5f;
    public float Velocidad_EjeY = 5f;
    public float Velocidad_Salto = 5.0f;
    public GameObject Prefab_Bala, Prefab_Golpe, Prefab_Explosion;
    public Transform Empty_Alessio;
    string Tipo_Arma;
    Rigidbody rigiBody;
    #endregion

    #region Llamado a otras clases del proyecto
    Movimiento movimiento;
    Golpear golpear;
    Pistola pistola;    
    Ataque_Alessio ataque_Alessio;
    #endregion


    #region Start & Update
    void Start()
    {
        golpear = new Golpear();
        pistola = new Pistola();
        #region Instanciamiento de Clases y Variables
        Tipo_Arma = golpear.getGolpear(); //Definir arma por defecto
        movimiento = new Movimiento(Velocidad_EjeX, Velocidad_EjeY, this.transform); //La clase movimiento necesita las velocidades del eje X e Y y el transform
        ataque_Alessio = new Ataque_Alessio();       
        ataque_Alessio.setAtaque_Alessio(Prefab_Bala, Prefab_Golpe, Empty_Alessio, Tipo_Arma); //Le damos los datos al ataque  de Alessio
        #endregion
    }
    
    void Update()
    {        
        movimiento._Movimiento(); //Ejecutar el movimiento
        Saltar();   //Para ejecutar e lsalto      
        ataque_Alessio.Atacar();    //Para ejecutar los ataques
        

    }
    #endregion

    #region Funciones

    
    public void Agarrar_Pistola() //Metodo para que Alessio pueda agarrar la pistola y cambiar de arma
    {
        pistola.transform.position = Empty_Alessio.position; //La pistola adopta la posición del objeto vacío
        pistola.transform.parent = Empty_Alessio.parent;   //La pistola y el objeto vacio comparten el mismo objeto padre = ALessio
        Tipo_Arma = pistola.getPistola(); //Cambiamos el tipo de arma
        ataque_Alessio.setAtaque_Alessio(Prefab_Bala, Prefab_Golpe, Empty_Alessio, Tipo_Arma);  //Le damos los datos al ataque  de Alessio
    }


    void OnTriggerEnter(Collider other)
    {       
        if (other.tag == "Pistola")
        {
            pistola = other.gameObject.GetComponent<Pistola>();
            Agarrar_Pistola();

        }
        if (other.tag == "Suelo")
        {
            rigiBody = GetComponent<Rigidbody>();
            rigiBody.velocity = new Vector3(0, 0, 0);
            rigiBody.useGravity = false;

        }
    }


    void Saltar()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            rigiBody = GetComponent<Rigidbody>();
            rigiBody.velocity = new Vector3(0, transform.position.y + Velocidad_Salto, 0);
            rigiBody.useGravity = true;
        }
    }
    public void morir()
    {
        Instantiate(Prefab_Explosion, transform.position, transform.rotation);
        Destroy(gameObject);   //Función para destruir al objeto Alessio
    }
    #endregion
}

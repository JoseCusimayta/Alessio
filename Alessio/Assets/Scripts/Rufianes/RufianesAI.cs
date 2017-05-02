using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RufianesAI : MonoBehaviour
{

    #region Variables
    public GameObject Prefab_Bala, Prefab_Rufian, Prefab_Explosion;
    public float frecDisparo = 1f;
    public Transform Empty_Rufianes;
    public int Vida_Rufianes = 10;
    float x, y, z;
    #endregion


    #region Start & Update
    void Start()
    {

    }
    
    void Update()
    {

    }
    #endregion


    private void OnBecameVisible()
    {
        InvokeRepeating("Disparo", 0, frecDisparo); //Dispara desde el momento en que es visible para el jugador si es que Alessio esta cerca
    }

    private void OnBecameInvisible()
    {
        CancelInvoke(); //Deja de disparar cuando sale de la camara
    }

    #region Funciones
    void Disparo()
    {
        Instantiate(Prefab_Bala, Empty_Rufianes.position, Empty_Rufianes.rotation); //Comienza a disparar desde el objeto vacio
    }
    public void Nuevo_Rufian()
    {
        x = Random.Range(10f, 20f); //Posición del eje Y al azar, entre 10 y 20
        y = Random.Range(-4f, 5f); //Posición del eje X al azar, entre -4 y 5
        z = 0.0f; //Posición del eje Z en 0
        Vector3 vector3 = new Vector3(x, y, z); //Se crea un vector para guardar la posición en los ejes
        Vida_Rufianes = 10; //Establecer cantidad de vida del rufian
        Instantiate(Prefab_Rufian, vector3, transform.rotation); //Crear un nuevo rufian con los anteriores valores 
    }

    public void morir()
    {
        Destroy(this.gameObject); //Destruir el objeto Rufian
    }

    void OnTriggerEnter(Collider otherObject)
    {
        /*
        if (otherObject.tag == "Player")
        {
            //Instanciar al enemigo, para sacar su funcion de morir para sacarlo de la memoria
            Alessio enemy = (Alessio)otherObject.gameObject.GetComponent("Alessio");
            //instanciar explosion

            //player.SetPositionAndSpeed();
            //Destroy(gameObject);
            if (enemy.golpear.getGolpe() == false)
            {
                Instantiate(Prefab_Explosion, enemy.transform.position, enemy.transform.rotation);
                enemy.morir();
            }
            if (enemy.golpear.getGolpe())
            {
                Debug.Log("Enemigo golpeado");
                //enemy.morir();
                Instantiate(Prefab_Explosion, this.transform.position, this.transform.rotation);
                this.morir();
                enemy.golpear.setGolpe(false);
                //this.morir();
            }
        }*/
        //if (player.golpe)
        //{ player.golpe = false; }
        //SetPositionAndSpeed();

        //DestroyInm(ExplosionPreFab);
    }
    #endregion

}
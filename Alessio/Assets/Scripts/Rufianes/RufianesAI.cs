using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RufianesAI : MonoBehaviour
{

    #region Variables
    public GameObject Prefab_Bala, Prefab_Rufian, Prefab_Explosion;
    public float frecDisparo = 1f;
    public Transform Empty_Rufianes;
    public int Vida_Rufianes = 6;
    float x, y, z;
    public GameObject player;
    float distanciaX, velocidad_rufian=1;
    bool Alessio_Detectado = false;
    float Intervalo_Ataque = 0;
    #endregion

    #region Clases auxiliares para la accion de disparo
    Disparar disparoEnemigo;
    Pistola pistolaEnemigo;
    #endregion

    #region Start & Update
    void Start()
    {
        pistolaEnemigo = new Pistola();
        
        disparoEnemigo = new Disparar(Prefab_Bala, Empty_Rufianes, pistolaEnemigo.getPistola());
    }
    
    void Update()
    {
        DetectarAlessio();
    }
    #endregion

    private void OnBecameVisible()
    {
        // InvokeRepeating("Disparo", 0, frecDisparo);//Dispara desde el momento en que es visible para el jugador si es que Alessio esta cerca

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

    void DetectarAlessio()
    {
        if (player!=null)
        {
            if (Vector3.Distance(player.transform.position, transform.position) < 10)
            {
                transform.position = Vector2.Lerp(transform.position, player.transform.position, velocidad_rufian * Time.deltaTime);
                Intervalo_Ataque -= Time.deltaTime;
                if (Intervalo_Ataque <= 0)
                {
                    disparoEnemigo._Disparar();
                    Intervalo_Ataque = 0.2f;
                }
            }
            if (player.transform.position.x > transform.position.x)
            {
                transform.rotation = new Quaternion(0, 180, 0, 0);
            }
            else
            {
                transform.rotation = new Quaternion(0, 0, 0, 0);
            }
        }
    }
    public void morir()
    {
        Instantiate(Prefab_Explosion, transform.position,transform.rotation);
        Destroy(gameObject); //Destruir el objeto Rufian
    }
    
    #endregion

}
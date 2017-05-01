using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RufianesAI : MonoBehaviour {

    #region Variables
    public GameObject Prefab_Bala, Prefab_Rufian, Prefab_Explosion;
    public float frecDisparo = 1f;
    public Transform Empty_Rufianes;
    public int Vida_Rufianes=10;
    private float x, y, z;
    #endregion

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnBecameVisible()
    {
        InvokeRepeating("Disparo", 0, frecDisparo); //Dispara desde el momento en que es visible para el jugador
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
        x = Random.Range(10f, 20f);
        y = Random.Range(-4f, 5f);
        z = 0.0f;
        Vector3 vector3 = new Vector3(x, y, z);
        Vida_Rufianes = 10;
        Instantiate(Prefab_Rufian, vector3, transform.rotation);
    }

    void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.tag == "Player")
        {
            //Instanciar al jugador, para sacar su funcion de morir para sacarlo de la memoria
            Golpear player = (Golpear)otherObject.gameObject.GetComponent("Player");
            //instanciar explosion
            Instantiate(Prefab_Explosion, player.transform.position, player.transform.rotation);
            //player.SetPositionAndSpeed();
            //Destroy(gameObject);
            if (player.golpe == false)
            {
                player.morir();
            }
            if (player.golpe)
            { player.golpe = false; }
            //SetPositionAndSpeed();

            //DestroyInm(ExplosionPreFab);
        }
    }
    #endregion

}

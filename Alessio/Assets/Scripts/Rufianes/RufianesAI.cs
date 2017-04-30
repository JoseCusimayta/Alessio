using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RufianesAI : MonoBehaviour {

    #region Variables
    public GameObject Prefab_Bala, Prefab_Rufian;
    public float frecDisparo = 1f;
    public Transform Empty_Rufianes;
    public int Vida_Rufianes=5;
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
        x = Random.Range(10f, 15f);
        y = Random.Range(-4f, 5f);
        z = 0.0f;
        Vector3 vector3 = new Vector3(x, y, z);
        Instantiate(Prefab_Rufian, vector3, transform.rotation);
        
    }
    #endregion

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Camara : MonoBehaviour {
    //Esta clase va dentro de la Main Camera

    #region Variables
    public GameObject player; //Variable para guardar el objeto 


    private Vector3 offset; //Variable privada para guardar distancia con el jugador
    #endregion
    // Use this for initialization
    void Start () {                
        offset = transform.position - player.transform.position; //La distancia original entre la camara y el jugador se mantendra para siempre...
    }
	
	// Update is called once per frame
	void Update () {
       
        if (player)  //Verifica si existe el objeto o no
        {            
            transform.position = player.transform.position + offset; //Si el objeto existe, la camara se moverá con el jugador
        }
    }
}

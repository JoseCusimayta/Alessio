using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

    #region Variables
    public float Velocidad_EjeX = 10f;
    public string Target_Tag;
    public GameObject Prefab_Explosion;
    #endregion

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Velocidad_EjeX * Time.deltaTime, 0, 0);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Target_Tag))
        {
            if (Target_Tag == "Rufianes")
            {
                #region Accion para Alessio si el objetivo es un rufian
                RufianesAI rufianesAI = (RufianesAI)other.gameObject.GetComponent("RufianesAI");//Instanciamos la clase RufianesAI            
                rufianesAI.Vida_Rufianes= rufianesAI.Vida_Rufianes - Pistola.Daño_Pistola; //Se resta la vida del rufian - el daño de la pistola
                if (rufianesAI.Vida_Rufianes <= 0)
                {
                    Destroy(other.gameObject); //Destruir al rufian
                    Record.Score++; //Aumentamos en 1 el record
                    rufianesAI.Nuevo_Rufian();
                }
                Destroy(gameObject); //Destruir bala
                #endregion
            }
            if (Target_Tag == "Player")
            {
                Alessio player = (Alessio)other.gameObject.GetComponent("Alessio");
                #region Accion para los Rufianes si el objetivo es Alessio
               
                Record.Lives= Record.Lives-Pistola.Daño_Pistola; //Restamos la vida del jugador - el daño de la pistola
                if (Record.Lives <= 0)
                {
                    Destroy(other.gameObject); //Destruir al jugador
                }
                Destroy(gameObject); //Destruir bala
                #endregion
            }
        }

    }


    private void OnBecameInvisible()
    {        
        Destroy(gameObject); //Destruye el objeto cuando sale de la camara
    }

    
}

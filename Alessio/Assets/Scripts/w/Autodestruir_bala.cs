using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestruir_bala : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Destruir", 15);
    }

    void Destruir()
    {
        Destroy(gameObject);
    }
}

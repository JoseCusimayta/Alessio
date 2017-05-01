using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpear : MonoBehaviour {
    public bool golpe = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //golpe
        bool keyGolpe = Input.GetKeyDown(KeyCode.N);

        if (keyGolpe)
        {
            golpe = true;
        }
    }

    public void morir()
    {
        Destroy(this.gameObject);
    }
}

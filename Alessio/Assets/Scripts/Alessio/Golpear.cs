using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpear  {
    private bool golpe=false;
    
    //constructor de la clase
    public Golpear(bool indicador)
    {
        golpe = indicador;
    }

    public void setGolpe(bool g)
    {
        golpe = g;
    }
    public bool getGolpe()
    { return golpe; }
	
	// Update is called once per frame
	//void Update () {
 //       //golpe
 //       bool keyGolpe = Input.GetKeyDown(KeyCode.N);

 //       if (keyGolpe)
 //       {
 //           golpe = true;
 //       }
 //   }

    
    public void AtaqueGolpe()
    {
        bool keyGolpe = Input.GetKeyDown(KeyCode.N);

        if (keyGolpe)
        {
            golpe = true;
        }
        //if (keyGolpe == false)
        //{
        //    golpe = false;
        //}
        Debug.Log("Golpe actual: " + golpe);
    }
   
}

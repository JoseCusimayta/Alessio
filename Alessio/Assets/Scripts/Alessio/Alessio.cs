using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alessio : MonoBehaviour {
    public float Velocidad_EjeX = 5f;
    public float Velocidad_EjeY = 5f;

    private Movimiento movimiento;
    public Golpear golpear;
    // Use this for initialization
    void Start()
    {
        //instanciamos a la clase movimiento, dandole los datos necesarios para que pueda brindar movimiento a Alessio
        movimiento = new Movimiento(Velocidad_EjeX, Velocidad_EjeY, this.transform);
        golpear = new Golpear(false);
        //movimiento._Movimiento(Velocidad_EjeX, Velocidad_EjeY,this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        //llamamos al metodo que dara movimiento a alessio, este metodo pertenece a la clase Movimiento
        movimiento._Movimiento();
        golpear.AtaqueGolpe();
    }

    //metodo que permite que alessio muera destruyendo su sprite
    public void morir()
    {
        Destroy(this.gameObject);
    }

    
}

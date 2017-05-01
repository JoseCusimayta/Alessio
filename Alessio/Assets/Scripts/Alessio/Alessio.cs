using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alessio : MonoBehaviour {
    public float Velocidad_EjeX = 5f;
    public float Velocidad_EjeY = 5f;
    private Rigidbody rb;
    public float jumpH = 5.0f;
    private Movimiento movimiento;
    public Golpear golpear;
    public Disparar disparar;
    public GameObject Prefab_Bala;
    public Transform Empty_Alessio;
    public string Arma;
    private Pistola pistola;
    public Record record;
    // Use this for initialization
    void Start()
    {
        //instanciamos a la clase movimiento, dandole los datos necesarios para que pueda brindar movimiento a Alessio
        movimiento = new Movimiento(Velocidad_EjeX, Velocidad_EjeY, this.transform);
        golpear = new Golpear(false);
        record = new Record();
        
        disparar = new Disparar(Prefab_Bala, Empty_Alessio,Arma);
        //movimiento._Movimiento(Velocidad_EjeX, Velocidad_EjeY,this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        //llamamos al metodo que dara movimiento a alessio, este metodo pertenece a la clase Movimiento
        movimiento._Movimiento();
        golpear.AtaqueGolpe();
        disparar._Disparar();
        Saltar();


    }

    //metodo que permite que alessio muera destruyendo su sprite
    public void morir()
    {
        Destroy(this.gameObject);
    }

    //metodo que carga la posicion y datos necesarios para la pistola, cuando la tome alessio, 
    public void ejecutarArma()
    {
        pistola.transform.position = Empty_Alessio.position;
        pistola.transform.parent = Empty_Alessio;
        disparar.Arma = "Pistola";
    }

    void Saltar()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            rb = this.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, transform.position.y + jumpH, 0);
            rb.useGravity = true;
        }
    }

    void OnGUI()
    {
        record.buildGUI();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Nos cruzamos con " + other.tag);
        if (other.tag == "Pistola")
        {
            Debug.Log("Me encontre una pistola");
            pistola = new Pistola();
            pistola = (Pistola)other.gameObject.GetComponent("Pistola");
            ejecutarArma();

        }
        if (other.tag == "Suelo")
        {
            Debug.Log("Golpe al suelo");
            rb = this.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, 0, 0);
            rb.useGravity = false;

        }
    }
}

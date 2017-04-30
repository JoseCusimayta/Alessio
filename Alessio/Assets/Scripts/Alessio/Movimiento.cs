using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {
    //ctrl + r : Rename Refactoring

    #region Variables
    public float Velocidad_EjeX = 5f;
    public float Velocidad_EjeY = 5f;
    #endregion

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        _Movimiento();

    }

    #region Funciones
    void _Movimiento()
    {
        //Metodo conocido, posiblemente a ser cambiado por otro metodo/modo
        #region Asignación de variables para detectar y usar
        float moveX = 0, moveY = 0;
        bool Key_W_Pressed = Input.GetKey(KeyCode.W);
        bool Key_D_Pressed = Input.GetKey(KeyCode.D);
        bool Key_A_Pressed = Input.GetKey(KeyCode.A);
        bool Key_S_Pressed = Input.GetKey(KeyCode.S);
        bool Key_Shift_Pressed = Input.GetKey(KeyCode.LeftShift);
        #endregion

        #region Movimiento Normal
        if (Key_W_Pressed)
        {
            moveY = Velocidad_EjeY;
        }
        if (Key_D_Pressed)
        {
            moveX = Velocidad_EjeX;
        }
        if (Key_A_Pressed)
        {
            moveX = -Velocidad_EjeX;
        }
        if (Key_S_Pressed)
        {
            moveY = -Velocidad_EjeY;
        }
        #endregion

        #region Acelerar

        if (Key_Shift_Pressed)
        {
            moveX = moveX * 2;
            moveY = moveY * 2;
        }
        #endregion

        transform.Translate(moveX * Time.deltaTime, moveY * Time.deltaTime, 0);//Ejecución del movimiento
    }
    #endregion
}

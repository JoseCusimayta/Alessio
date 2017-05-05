using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento{
    //ctrl + r : Rename Refactoring

    #region Variables
    private float Velocidad_EjeX = 5f;
    private float Velocidad_EjeY = 5f;
    private Transform transMovimiento;
    float Limite_Mapa_Top = 10;
    float Limite_Mapa_Bottom = -10;
    float Limite_Mapa_Right = 30;
    float Limite_Mapa_Left = -10;
    #endregion

    #region Constructor
    public Movimiento(float x,float y, Transform trans)
    {
        Velocidad_EjeX = x;
        Velocidad_EjeY = y;
        transMovimiento = trans;
    }
    #endregion

    #region Funciones
    public void _Movimiento()
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
            if (transMovimiento.position.y < Limite_Mapa_Top)
            {
                moveY = Velocidad_EjeY;
            }
        }
        if (Key_D_Pressed)
        {
            if (transMovimiento.position.x < Limite_Mapa_Right)
            {
                moveX = Velocidad_EjeX;
            }
        }
        if (Key_A_Pressed)
        {
            if (transMovimiento.position.x > Limite_Mapa_Left)
            {
                moveX = -Velocidad_EjeX;
            }
        }
        if (Key_S_Pressed)
        {
            if (transMovimiento.position.y > Limite_Mapa_Bottom)
            {
                moveY = -Velocidad_EjeY;
            }
        }
        #endregion

        #region Acelerar

        if (Key_Shift_Pressed)
        {
            moveX = moveX * 2;
            moveY = moveY * 2;
        }
        #endregion
        
        transMovimiento.Translate(moveX * Time.deltaTime, moveY * Time.deltaTime, 0);//Ejecución del movimiento
    }
    #endregion
}

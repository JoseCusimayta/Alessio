using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record : MonoBehaviour {

    #region Variables
    public static int Score = 0;
    public static int Lives = 10;
    #endregion

   

    #region Funciones
    public void buildGUI()
    {
        GUI.contentColor = Color.red;
        GUI.Label(new Rect(0, 0, 120, 240), "Score=" + Score.ToString());
        GUI.Label(new Rect(60, 0, 120, 240), "Lives=" + Lives.ToString());
    }
    #endregion
}

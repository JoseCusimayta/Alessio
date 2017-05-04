using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record {

    #region Variables
    public static int Score = 0;
    public static int Lives = 10;
    #endregion

    #region Funciones
    public void buildGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 90), "Alessio");
        GUI.Label(new Rect(35, 35, 100, 90), "Score=" + Score.ToString());
        GUI.Label(new Rect(35, 65, 100, 90), "Lives=" + Lives.ToString());
    }
    #endregion
}

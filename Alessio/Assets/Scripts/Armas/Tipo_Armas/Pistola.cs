using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistola : MonoBehaviour{

    #region Variables
    public static int Daño_Pistola=3;
    public static string tipoArma = "Pistola";
    
    #endregion

   
    public string getPistola()
    {
        return tipoArma;
    }
}

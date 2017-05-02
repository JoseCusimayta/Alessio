using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestruir_bala : MonoBehaviour {

    #region Start & Update
    void Start () {
        Invoke("Destruir", 15);
    }
    #endregion

    #region Funciones
    void Destruir()
    {
        Destroy(gameObject);
    }
    #endregion
}

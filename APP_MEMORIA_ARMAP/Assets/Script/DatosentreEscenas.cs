using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosentreEscenas : MonoBehaviour
{

    //Mantentener tiempo en otras escenas, SINGLETONS
    public static DatosentreEscenas inst;

    #region Reloj
    public Text myText;
    public float tiempo_mostrar = 0f;
    #endregion
    private void Awake()
    {
        if (inst == null)
        {
            inst = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Set_Tiempo(float t)
    {
        tiempo_mostrar = t;
    }

    public float Get_tiempo()
    {
        return tiempo_mostrar;
    }
}

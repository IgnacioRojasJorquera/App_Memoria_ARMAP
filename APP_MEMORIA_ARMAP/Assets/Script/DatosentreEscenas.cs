using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosentreEscenas : MonoBehaviour
{

    //Mantentener tiempo en otras escenas, SINGLETONS
    public static DatosentreEscenas inst;

    public int money;
    private int item;

    #region Reloj
    public Text myText;
    private float tiempo_mostrar;

    public Text textoRecord;

    //private float escala_tiempo_pausa;
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
            /*if(inst != this)
            {
                Destroy(gameObject);
            }
            */
        }
    }
    /*
    public void SetItems(int i)
    {
        item = i;
    }

    public float GetItems()
    {
        return item;
    }
    */
    public void Set_Tiempo(float t)
    {
        tiempo_mostrar = t;
    }

    public float Get_tiempo()
    {
        return tiempo_mostrar;
    }
}

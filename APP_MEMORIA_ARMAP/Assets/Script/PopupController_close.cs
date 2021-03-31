using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupController_close : MonoBehaviour
{
    public GameObject cerrar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Open_Cerrar()
    {
        cerrar.SetActive(true);
    }

    public void Close_Cerrar()
    {
        cerrar.SetActive(false);
    }

}

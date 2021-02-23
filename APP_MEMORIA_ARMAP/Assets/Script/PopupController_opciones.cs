using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupController_opciones : MonoBehaviour
{
    public GameObject mapa_guia;
    public GameObject test;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Open_MapaGuia()
    {
        mapa_guia.SetActive(true);
    }

    public void Close_MapaGuia()
    {
        mapa_guia.SetActive(false);
    }

    public void Open_Test()
    {
        test.SetActive(true);
    }

    public void Close_Test()
    {
        test.SetActive(false);
    }
}

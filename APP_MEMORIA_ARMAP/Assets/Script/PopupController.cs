using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupController : MonoBehaviour
{
    public GameObject mapa_POI;
    public GameObject muni;
    public GameObject docu;
    public GameObject cappissima;
    public GameObject uta;
    public GameObject sismologia;
    public GameObject kit;
    public GameObject miedo;
    public GameObject rcp;
    public GameObject fractura;
    public GameObject hemorragia;
    public GameObject fono;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Pop up
    public void MapaPOI()
    {
        mapa_POI.SetActive(true);
    }

    public void Close_mapaPOI()
    {
        mapa_POI.SetActive(false);
    }

    public void Muni()
    {
        muni.SetActive(true);
    }

    public void Close_Muni()
    {
        muni.SetActive(false);
    }

    public void Docu()
    {
        docu.SetActive(true);
    }

    public void Close_Docu()
    {
        docu.SetActive(false);
    }

    public void Capi()
    {
        cappissima.SetActive(true);
    }

    public void Close_Capi()
    {
        cappissima.SetActive(false);
    }

    public void Uta()
    {
        uta.SetActive(true);
    }

    public void Close_Uta()
    {
        uta.SetActive(false);
    }

    public void Sismologia()
    {
        sismologia.SetActive(true);
    }

    public void Close_Sismologia()
    {
        sismologia.SetActive(false);
    }

    public void Kit()
    {
        kit.SetActive(true);
    }

    public void Close_Kit()
    {
        kit.SetActive(false);
    }

    public void Miedo()
    {
        miedo.SetActive(true);
    }

    public void Close_Miedo()
    {
        miedo.SetActive(false);
    }

    public void Rcp()
    {
        rcp.SetActive(true);
    }

    public void Close_Rcp()
    {
        rcp.SetActive(false);
    }

    public void Fractura()
    {
        fractura.SetActive(true);
    }

    public void Close_Fractura()
    {
        fractura.SetActive(false);
    }

    public void Hemorragia()
    {
        hemorragia.SetActive(true);
    }

    public void Close_Hemorragia()
    {
        hemorragia.SetActive(false);
    }

    public void Fono()
    {
        fono.SetActive(true);
    }

    public void Close_Fono()
    {
        fono.SetActive(false);
    }
}

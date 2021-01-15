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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
}

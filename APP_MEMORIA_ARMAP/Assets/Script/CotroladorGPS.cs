using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using UnityEngine.UI;
using System;
using System.Linq;

public class CotroladorGPS : MonoBehaviour
{
    string filePath;
    string jsonStrig;

    public GameObject objeto1;
    public List<Item> items = new List<Item>();

    //private string prefabName = "listPrefab";

    GameObject contentHolder;
    //GameObject thePrefab;
    /*private void Start()
    {
      contentHolder = GameObject.FindWithTag("Content");
    }*/

    private void Awake()
    {
        contentHolder = GameObject.FindWithTag("Content");

        filePath = Application.dataPath + "/Coordenadas.json";
        jsonStrig = File.ReadAllText(filePath);
        ListaCoordenadas listaCoordenadas = JsonUtility.FromJson<ListaCoordenadas>(jsonStrig);
        //print(listaCoordenadas);
       
        listaCoordenadas.Listar();


        //Coordenada coordenada = JsonUtility.FromJson<Coordenada>(jsonStrig);
        //string prefabName; ;

        for (int i =0; i < listaCoordenadas.coordenadas.Count; i++)
        {
            GameObject thePrefab = Instantiate(objeto1);
            //GameObject thePrefab = Instantiate(Resources.Load("Assets/pack2/ButtonPrefabs/listPrefab")) as GameObject;
            GameObject contentHolder = GameObject.FindWithTag("Content");
               
            thePrefab.transform.parent = contentHolder.transform;
            Text[] theText = thePrefab.GetComponentsInChildren<Text>();
            theText[0].text = listaCoordenadas.coordenadas[i].nombre;

            Debug.Log(theText[0].text + ": " + Math.Round(GeoCodeCalc.CalcDistance(41.648408, 2.739420, listaCoordenadas.coordenadas[i].latitud, listaCoordenadas.coordenadas[i].longitud, GeoCodeCalcMeasurement.Metre), 2));
            //Debug.Log(theText[0].text + ": " + Math.Round(GeoCodeCalc.CalcDistance(-18.455141333306248, -70.28160946087549, -18.454795312541773, -70.284366771555, GeoCodeCalcMeasurement.Metre), 2));
            //double distancia = Math.Round(GeoCodeCalc.CalcDistance(-18.455141333306248, -70.28160946087549, listaCoordenadas.coordenadas[i].latitud, listaCoordenadas.coordenadas[i].longitud, GeoCodeCalcMeasurement.Metre), 2);
            //double distancia = Math.Round(GeoCodeCalc.CalcDistance(GPS.latitude, GPS.longitude, listaCoordenadas.coordenadas[i].latitud, listaCoordenadas.coordenadas[i].longitud, GeoCodeCalcMeasurement.Metre), 2);
            double distancia = Math.Round(GeoCodeCalc.CalcDistance(-18.455141333306248, -70.28160946087549, listaCoordenadas.coordenadas[i].latitud, listaCoordenadas.coordenadas[i].longitud, GeoCodeCalcMeasurement.Metre), 2);

            theText[1].text = "Distancia : " + distancia.ToString() + "m";

            thePrefab.transform.localScale = new Vector3(1,1,1);
            items.Add(new Item(listaCoordenadas.coordenadas[i].nombre, distancia));

            //Button[] button = thePrefab.GetComponentsInChildren<Button>();
            //button[0].name = listaCoordenadas.coordenadas[i].nombre;
            /*
            double tLat = listaCoordenadas.coordenadas[i].latitud;
            double tLon = listaCoordenadas.coordenadas[i].longitud;
            string url = "https://www.google.cl/maps/place/Panguipulli+1224,+Arica,+Arica+y+Parinacota/"+tLat+","+tLon+"/@-18.4551617,-70.2837767,17z/data=!3m1!4b1!4m5!3m4!1s0x915aa8f8ba4a38b3:0x847aff94b2ca184b!8m2!3d-18.4551617!4d-70.281588?hl=en&authuser=1";
            AddListener(button[0], url);
            */
        }
        //Debug.Log(items.Count);
        //RePopular(items);
        OderByDistance(items);
    }
    /*
    void AddListener(Button b, string url)
    {
        b.onClick.AddListener(()=> Application.OpenURL(url));
    }
    */

    void OderByDistance(List<Item> itemsPassed)
    {
        itemsPassed = itemsPassed.OrderBy(a => a.TheDistance).ToList();
        RePopular(itemsPassed);
    }
    void RePopular(List<Item> itemsPassed)
    {
        foreach (Transform child in contentHolder.transform)
        {
            //Debug.Log("Matando :"+child.gameObject.name);
            Destroy(child.gameObject);
        }

        for (int i = 0; i<itemsPassed.Count; i++)
        {
            GameObject thePrefab = Instantiate(objeto1);
            thePrefab.transform.parent = contentHolder.transform;
            Text[] theText = thePrefab.GetComponentsInChildren<Text>();
            theText[0].text = itemsPassed[i].TheTitle;
            theText[1].text = "Distancia :"+itemsPassed[i].TheDistance.ToString()+"m";

            thePrefab.transform.localScale = new Vector3(1, 1, 1);

        }
    }
}

public class Item
{
    //public string Pname;
    public string TheTitle;
    public double TheDistance;
    //public string TheURL;

    public Item(/*string pname, */string thetile, double thedistance/*, string theurl*/)
    {
        //Pname = pname;
        TheTitle = thetile;
        TheDistance = thedistance;
        //TheURL = theurl;
    }
}

[System.Serializable]
public class Coordenada
{
    public double latitud;
    public double longitud;
    public string nombre;
    /*
    public override string ToString()
    {
       return string.Format ("Nombre: {0} , Latitud: {1} , Longitud: {2}", nombre, latitud, longitud);
    }
    */
}


[System.Serializable]
public class ListaCoordenadas
{
    public List<Coordenada> coordenadas;
    //int i = 0;
    public void Listar()
    {
        //string theWord = ScenneController;
        //string prefabName = "listPrefab";



        foreach (Coordenada coordenada in coordenadas)
        {
            //i++;
            Debug.Log(coordenada);
            //Debug.Log(i);
            //GameObject thePrefab = (Resources.Load("ButtonPrefabs/" + prefabName)) as GameObject;
            //GameObject contentHolder = GameObject.FindGameObjectsWithTag("Content")[0];

            //thePrefab.transform.parent = contentHolder.transform;
                
        }
    }

}
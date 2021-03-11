using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CotroladorGPS : MonoBehaviour
{
    string filePath;
    string jsonStrig;

    private void Awake()
    {
        filePath = Application.dataPath + "/Coordenadas.json";
        jsonStrig = File.ReadAllText(filePath);
        ListaCoordenadas listaCoordenadas = JsonUtility.FromJson<ListaCoordenadas>(jsonStrig);
        //print(listaCoordenadas);
        listaCoordenadas.Listar();
    }
}

[System.Serializable]
public class Coordenada
{
    public float latitud;
    public float longitud;
    
    public override string ToString()
    {
       return string.Format ("Latitud: {0} , Longitud: {1}", latitud, longitud);
    }
    
}


[System.Serializable]
public class ListaCoordenadas
{
    public List<Coordenada> coordenadas;

    public void Listar()
    {
        foreach (Coordenada coordenada in coordenadas)
        {
            Debug.Log(coordenada);
        }
    }

}
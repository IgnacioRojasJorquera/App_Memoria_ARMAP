using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlacesWeb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnlaceBoton(string enlace)
    {
        Application.OpenURL(enlace);
    }
}

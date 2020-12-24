using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventoReloj : MonoBehaviour
{
    private void OnEnable()
    {
        Reloj.LlegarACero += CambiarColor;
    }

    private void OnDisable()
    {
        Reloj.LlegarACero -= CambiarColor;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CambiarColor()
    {
        GetComponent<Image>().color = Color.red;
    }

}

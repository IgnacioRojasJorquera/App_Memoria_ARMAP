using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reloj : MonoBehaviour
{
    [Tooltip("Tiempo inicial en segundos")]
    public int tiempo_inicial;

    [Tooltip("Escala del tiempo del reloj")]
    [Range(-10.0f,10.0f)]
    public float escala_tiempo = 1;

    private Text myText;
    private float tiempo_frame_escala_tiempo = 0f;
    private float tiempo_mostrar = 0f;
    private float escala_tiempo_pausar, escala_tiempo_inicial;
    private bool pausado = false;

    // Start is called before the first frame update
    void Start()
    {
        //Establecer escala de tiempo original
        escala_tiempo_inicial = escala_tiempo;

        //Obtener texto para referenciar
        myText = GetComponent<Text>();

        //Inicializar la variable que acumula los tiempos de cada frame con el tiempo inicial
        tiempo_mostrar = tiempo_inicial;

        ActualizarReloj(tiempo_inicial);
    }

    // Update is called once per frame
    void Update()
    {
        //Tiempo de cada frame considerando al escala de tiempo
        tiempo_frame_escala_tiempo = Time.deltaTime * escala_tiempo;

        //Acumula el tiempo transcurrido y muestra en reloj
        tiempo_mostrar += tiempo_frame_escala_tiempo;
        ActualizarReloj(tiempo_mostrar);
    }

    public void ActualizarReloj(float tiempo_segundos)
    {
        string texto_reloj;

        //Asegurar el tiempo no sea negativo
        if (tiempo_segundos < 0)
            tiempo_segundos = 0;

        //Calcular minutos y segundos
        int minutos = (int)tiempo_segundos / 60;
        int segundos = (int)tiempo_segundos % 60;

        //Crear cadena de caracter con 2 digitos para minutos y segundos
        texto_reloj = minutos.ToString("00") + ":" + segundos.ToString("00");

        //Actualizar elemento text de UI 
        myText.text = texto_reloj;
    }
}

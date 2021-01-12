using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reloj : MonoBehaviour
{
    [Tooltip("Tiempo inicial en segundos")]
    public int tiempo_inicial;

    [Tooltip("Escala del tiempo del reloj")]
    [Range(-10.0f, 10.0f)]
    public float escala_tiempo = 1;


    private Text myText; //rescatar
    private float tiempo_frame_escala_tiempo = 0f;
    private float tiempo_mostrar = 0f; //rescatar
    private float escala_tiempo_pausar, escala_tiempo_inicial;
    private bool pausado = false;
    private bool evento_tiempo_cero = false;

    public Text textoRecord;

    //Crear delegado para evento tiempo cero
    public delegate void AccionTimpoCero();
    //Crear tiempo
    public static event AccionTimpoCero LlegarACero;

    /*
    //Mantentener tiempo en otras escenas, SINGLETONS
    public static Reloj inst_reloj;
    private void Awake()
    {
        if (inst_reloj == null)
        {
            Reloj.inst_reloj = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    */
    private void Awake()
    {
        //LoadData();
        //DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        LoadData();
        //Establecer escala de tiempo original
        escala_tiempo_inicial = escala_tiempo;

        //Obtener texto para referenciar
        myText = GetComponent<Text>();

        //Inicializar la variable que acumula los tiempos de cada frame con el tiempo inicial
        tiempo_mostrar = tiempo_inicial;

        ActualizarReloj(tiempo_inicial);

        textoRecord.text = PlayerPrefs.GetFloat("Puntaje_Record", tiempo_inicial).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(!pausado)
        {
            //Tiempo de cada frame considerando al escala de tiempo
            tiempo_frame_escala_tiempo = Time.deltaTime * escala_tiempo;

            //Acumula el tiempo transcurrido y muestra en reloj
            tiempo_mostrar += tiempo_frame_escala_tiempo;
            ActualizarReloj(tiempo_mostrar);
        }
        
    }

    public void ActualizarReloj(float tiempo_segundos)
    {
        string texto_reloj;

        //Disparar evento al llegar a cero
        if(tiempo_segundos <=0 && !evento_tiempo_cero)
        {
            if(LlegarACero != null)
            {
                LlegarACero();
            }
            evento_tiempo_cero = true;
        }

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

    public void GrabarRecord()
    {
        if (!pausado)
        {
            pausado = true;
            escala_tiempo_pausar = escala_tiempo;
            escala_tiempo = 0;
            //Playerprefs
            //textoRecord.text = tiempo_mostrar.ToString();
            //PlayerPrefs.SetFloat("Puntaje_Record", tiempo_mostrar);

            if (tiempo_mostrar < PlayerPrefs.GetFloat("Puntaje_Record", tiempo_inicial))
            {
                PlayerPrefs.SetFloat("Puntaje_Record", tiempo_mostrar);
                textoRecord.text = tiempo_mostrar.ToString();
            }

        }
    }
    public void Pausar()
    {
        if (!pausado)
        {
            pausado = true;
            escala_tiempo_pausar = escala_tiempo;
            escala_tiempo = 0;
            //Playerprefs
            //textoRecord.text = tiempo_mostrar.ToString();
            //PlayerPrefs.SetFloat("Puntaje_Record", tiempo_mostrar);
            /*
            if (tiempo_mostrar < PlayerPrefs.GetFloat("Puntaje_Record",tiempo_inicial))
            {
                PlayerPrefs.SetFloat("Puntaje_Record", tiempo_mostrar);
                textoRecord.text = tiempo_mostrar.ToString();
            }
            */
        }
    }

    public void Continuar()
    {
        if(pausado)
        {
            pausado = false;
            escala_tiempo = escala_tiempo_pausar;
        }
    } 

    public void Reiniciar()
    {
        pausado = false;
        evento_tiempo_cero = false;
        escala_tiempo = escala_tiempo_inicial;
        tiempo_mostrar = tiempo_inicial;
        ActualizarReloj(tiempo_mostrar);
    }

    private void onDestroy()
    {
        SaveData();
    }

    private void SaveData()
    {
        //DatosentreEscenas.inst.textoRecord = textoRecord;
        DatosentreEscenas.inst.myText = myText;
        DatosentreEscenas.inst.Set_Tiempo(tiempo_mostrar);
    }

    private void LoadData()
    {
        //textoRecord = DatosentreEscenas.inst.textoRecord;
        myText = DatosentreEscenas.inst.myText;
        tiempo_mostrar = DatosentreEscenas.inst.Get_tiempo();
    }
    
    public void BorrarDatos()
    {
        PlayerPrefs.DeleteKey("Puntaje_Record");
        textoRecord.text = tiempo_inicial.ToString();
    }
    
}

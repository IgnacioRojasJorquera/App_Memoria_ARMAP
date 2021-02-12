using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DatosentreEscenas : MonoBehaviour
{
    public Record recordCorrespondiente;//para mover record y reloj

    //Mantentener tiempo en otras escenas, SINGLETONS
    public static DatosentreEscenas inst;

    public int money;
    private int item;

    //public GameObject mover; //mover reloj
    //public Transform MainCanvas;


    #region Reloj
    public Text myText;
    private float tiempo_mostrar;

    public Text textoRecord;

    //private float escala_tiempo_pausa;
    #endregion
    private void Awake()
    {
        if (inst == null)
        {
            inst = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            /*if(inst != this)
            {
                Destroy(gameObject);
            }
            */
        }
    }
    /*
    public void SetItems(int i)
    {
        item = i;
    }

    public float GetItems()
    {
        return item;
    }
    */
    public void Set_Tiempo(float t)
    {
        tiempo_mostrar = t;
    }

    public float Get_tiempo()
    {
        return tiempo_mostrar;
    }

    /*
    public Popup CreatePopup()
    {
        GameObject popUpGo = Instantiate(Resources.Load("UI/popup") as GameObject);
        return popUpGo.GetComponent<Popup>();
    }
    */

    public void changeScene(string scene)
    {
         
        //Mover_inicial();
        //starPosicion = mover.transform.position;
       SceneManager.LoadSceneAsync(scene);
        
        if (scene != "Test_Oficial")
        {
            recordCorrespondiente.MoverRecord();
            print("Entre a mover panel");
            //Mover();
        }
        else
        {
            recordCorrespondiente.PosicionOrigenRecord();
            print("entre a else");
            //Mover_inicial();
            //print("Entre a dejar estado inicial");
        }
        
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }

    /*public void Mover()
    {
        //mover.transform.position = new Vector3(x: -850,y:-50);
        mover.transform.position = new Vector2(x: -778, y: 0);
    }

    public void Mover_inicial()
    {
        mover.transform.position = new Vector2(x: 11, y: 0.5f);
        //mover.transform.position = starPosicion;
        print("Entre a dejar estado inicial");
    }
    */
}

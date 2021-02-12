using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Record : MonoBehaviour
{
    public bool mover = false;
    Vector3 posicionOriginal;
   // public DatosentreEscenas moverIncial;

    // Start is called before the first frame update
    void Start()
    {
        posicionOriginal = transform.position;
    }

    // Update is called once per frame
    public void MoverRecord()
    {
        
        mover = !mover;
        if(mover)
        {
            transform.position = posicionOriginal + new Vector3(x: -778, y: 0,z:0);
        }
        else
        {
            transform.position = posicionOriginal;
        }
        
    }

    public void PosicionOrigenRecord()
    {
        transform.position = posicionOriginal;
    }
}

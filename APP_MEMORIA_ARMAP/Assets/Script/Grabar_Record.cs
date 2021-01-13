using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Grabar_Record : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Action action = () =>
        {
            Camera.main.backgroundColor = Color.red;
        };

        Button button = GetComponent<Button>();
        button.onClick.AddListener(() =>{
            Popup popup = UIController.inst.CreatePopup();
            //Init popup parametros (canvas, text, text, text, action) 
            popup.Init(UIController.inst.MainCanvas,
                "Quieres grabar el record?",
                "Tal vez no",
                "Seguro",
                action
                );
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

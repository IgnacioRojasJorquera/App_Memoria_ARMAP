using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Popup : MonoBehaviour
{
    [SerializeField] Button _boton1;
    [SerializeField] Button _boton2;
    [SerializeField] Text _boton1Text;
    [SerializeField] Text _boton2Text;
    [SerializeField] Text _popupText;
    
    public void Init(Transform canvas, string popupMessaje, string btn1txt, string btn2txt, Action action)
    {
        _popupText.text = popupMessaje;
        _boton1Text.text = btn1txt;
        _boton2Text.text = btn2txt;

        transform.SetParent(canvas);
        transform.localScale = Vector3.one;
        transform.localPosition = Vector3.zero;

        _boton1.onClick.AddListener(() =>{
            GameObject.Destroy(this.gameObject);
        });
        
        _boton2.onClick.AddListener(() =>{
            action();
        });
    }
}

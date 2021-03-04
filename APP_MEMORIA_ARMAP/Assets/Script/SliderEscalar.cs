using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderEscalar : MonoBehaviour
{
    public GameObject modelo2d;
    public Slider sliderEscalar;

    public void EscalarModelo()
    {
        modelo2d.transform.localScale = new Vector2(sliderEscalar.value, sliderEscalar.value);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public GameObject car;
    public Slider slider;

    GameObject carModel;

    Color32 startColor = new Color32(0, 0, 0, 255);
    Color32 endColor = new Color32(233, 233, 233, 255);

    //Renderer obj;

    private void Start()
    {

        carModel = Instantiate(car);
    }

    private void Update()
    {

        carModel.GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColor, slider.value / slider.maxValue); 
    }
}

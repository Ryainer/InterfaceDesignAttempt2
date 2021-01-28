using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public GameObject car;
    public Slider slider;

    public Transform carModel;

    Color32 startColor = new Color32(233, 233, 233, 255);
    Color32 endColor = new Color32(245, 150, 65, 255);

    //Renderer obj;

    private void Start()
    {

        carModel = car.transform.Find("body");
    }

    private void Update()
    {
       
        //carModel.GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColor, slider.value / slider.maxValue); 
        carModel.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, slider.value / slider.maxValue);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButtonScript : MonoBehaviour
{
    public GameObject slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onBtnPress()
    {
        if(slider.activeInHierarchy)
        {
            slider.SetActive(false);
        }
        else if(!slider.activeInHierarchy)
        {
            slider.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationBtnScript : MonoBehaviour
{

    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        //Panel = GameObject.Find("Location");
    }

    public void onLocationBtnPressed()
    {
        if (Panel.activeInHierarchy)
        {
            Panel.SetActive(false);
        }
        else if(!Panel.activeInHierarchy)
        {
            Panel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelData : MonoBehaviour
{
    //public GameObject wheel1;
    public GameObject outPutTxt;

    public int level;
    //public int level2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        outPutTxt.GetComponent<Text>().text = "Level: " + level;
    }
}

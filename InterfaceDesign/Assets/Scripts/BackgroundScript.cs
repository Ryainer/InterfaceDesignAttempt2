using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScript : MonoBehaviour
{
    public GameObject ResultBG;

    public GameObject BG1;
    public GameObject BG2;
    public GameObject BG3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnBackGround1Press()
    {
        ResultBG.GetComponent<Image>().sprite = BG1.GetComponent<Image>().sprite;
    }

    public void OnBackGround2Press()
    {
        ResultBG.GetComponent<Image>().sprite = BG2.GetComponent<Image>().sprite;
    }

    public void OnBackGround3Press()
    {
        ResultBG.GetComponent<Image>().sprite = BG3.GetComponent<Image>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

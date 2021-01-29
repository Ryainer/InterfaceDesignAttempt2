using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class swapPartsTabScript : MonoBehaviour
{
    public Sprite engineImage1;
    public Sprite engineImage2;

    public Sprite coilImage1;
    public Sprite coilImage2;

    public Sprite wheelPart1;
    public Sprite wheelPart2;

    public GameObject image1;
     public GameObject image2;
    public GameObject partsPanel;

    // Start is called before the first frame update
    void Start()
    {
        image1 = partsPanel.transform.GetChild(7).gameObject;
        image2 = partsPanel.transform.GetChild(8).gameObject;


        //image1.transform.position = new Vector3(-202.0f, -56.81752f, -6.0f);
        //image2.transform.position = new Vector3(1.02339f, -58.0948f, -6.0f);

        //image1.transform.localScale = new Vector3(35.5f, 1.5f, 0.0f);
        //image2.transform.localScale = new Vector3(1.5f, 1.5f, 0.0f);
    }

    public void onEngineBtnPress()
    {
        image1.GetComponent<SpriteRenderer>().sprite = engineImage1;
        image2.GetComponent<SpriteRenderer>().sprite = engineImage2;



       // image1.transform.position = new Vector3(-202.0f, -56.81752f, -6.0f);
       // image2.transform.position = new Vector3(1.02339f, -58.0948f, -6.0f);
        image1.transform.localScale = new Vector3(25.5f, 25.5f, 0.0f);
        image2.transform.localScale = new Vector3(25.5f, 25.5f, 0.0f);
    }

    public void onCoilBtnPress()
    {
        image1.GetComponent<SpriteRenderer>().sprite = coilImage1;
        image2.GetComponent<SpriteRenderer>().sprite = coilImage2;


        //  image1.transform.position = new Vector3(-202.0f, -56.81752f, -6.0f);
        // image2.transform.position = new Vector3(1.02339f, -58.0948f, -6.0f);
        image1.transform.localScale = new Vector3(25.5f, 25.5f, 0.0f);
        image2.transform.localScale = new Vector3(25.5f, 25.5f, 0.0f);
    }

    public void onPartBtnPress()
    {
        image1.GetComponent<SpriteRenderer>().sprite = wheelPart1;
        image2.GetComponent<SpriteRenderer>().sprite = wheelPart2;


      //  image1.transform.position = new Vector3(-202.0f, -56.81752f, -6.0f);
       // image2.transform.position = new Vector3(1.02339f, -58.0948f, -6.0f);
        //image1.transform.localScale = new Vector3(1.5f, 1.5f, 0.0f);
        //image2.transform.localScale = new Vector3(1.5f, 1.5f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

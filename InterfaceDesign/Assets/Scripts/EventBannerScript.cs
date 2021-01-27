using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EventBannerScript : MonoBehaviour
{
    private Image imageSlideShow;
    public GameObject Panel;
    public float maxTimeSwitch;
    public float m_speed;
    public bool isHidden;
    private Object[] textures;
    public int atWhich;
    private float timeSwitch;
    private bool switchImage;
    private bool isRight;
    private Vector3 prevPos;

    // Start is called before the first frame update
    void Start()
    {
        //atWhich = 0;
        timeSwitch = maxTimeSwitch;
        imageSlideShow = GetComponent<Image>();
        textures = Resources.LoadAll("SlideShow", typeof(Sprite));
        foreach (var t in textures)
        {
            Debug.Log(t.name);
        }
       // Debug.Log(textures.Length);
        imageSlideShow.sprite = textures[atWhich] as Sprite;
    }

    // Update is called once per frame
    void Update()
    {
        timeSwitch -= Time.deltaTime;
        if (timeSwitch <= 0f)
        {
            timeSwitch = maxTimeSwitch;
            if (switchImage == false)
            {
                onActivateRight();
            }
        }
        //  Debug.Log(imageSlideShow.GetComponent<RectTransform>().localPosition.x);
        if (switchImage == true)
        {
            if(isRight == true)
            {
                if (imageSlideShow.GetComponent<RectTransform>().localPosition.x < prevPos.x + Panel.GetComponent<RectTransform>().sizeDelta.x)
                {
                    imageSlideShow.GetComponent<RectTransform>().localPosition += new Vector3(Time.deltaTime * m_speed, 0f, 0f);
               
                }
                else if (imageSlideShow.GetComponent<RectTransform>().localPosition.x >= Panel.GetComponent<RectTransform>().sizeDelta.x )
                {
                    if (textures.Length >= 3)
                    {
                        for (int i = 0; i < 2; ++i) //For transition the moment it reaches the end and when it goes back to the front
                        {
                            if (atWhich >= textures.Length - 1)
                            {
                                atWhich = 0;

                            }
                            else
                            {
                                atWhich += 1;
                            }
                        }
                       
                        imageSlideShow.sprite = textures[atWhich] as Sprite;
                    }
                        
                    //    isHidden = true;
                        imageSlideShow.GetComponent<RectTransform>().localPosition = new Vector3(0 - Panel.GetComponent<RectTransform>().sizeDelta.x, imageSlideShow.GetComponent<RectTransform>().localPosition.y, imageSlideShow.GetComponent<RectTransform>().localPosition.z);
                        switchImage = false;
                }
                else
                {
                  //  isHidden = false;
                    switchImage = false;
                }
               
               
            }
            else
            {
                if (imageSlideShow.GetComponent<RectTransform>().localPosition.x > prevPos.x - Panel.GetComponent<RectTransform>().sizeDelta.x)
                {
                   imageSlideShow.GetComponent<RectTransform>().localPosition -= new Vector3(Time.deltaTime * m_speed, 0f, 0f);
         
                }
                else if (imageSlideShow.GetComponent<RectTransform>().localPosition.x < -Panel.GetComponent<RectTransform>().sizeDelta.x)
                {
                    if (textures.Length >= 3)
                    {
                        for (int i = 0; i < 2; ++i) //For transition the moment it reaches the end and when it goes back to the front
                        {
                            if (atWhich <= 0)
                            {
                                atWhich = textures.Length - 1;
                            }
                            else
                            {
                                atWhich -= 1;
                            }
                        }
                        imageSlideShow.sprite = textures[atWhich] as Sprite;
                    }
                   
                   // isHidden = true;
                    imageSlideShow.GetComponent<RectTransform>().localPosition = new Vector3(Panel.GetComponent<RectTransform>().sizeDelta.x, imageSlideShow.GetComponent<RectTransform>().localPosition.y, imageSlideShow.GetComponent<RectTransform>().localPosition.z);
                    switchImage = false;
                }
                else
                {
                   // isHidden = false;
                    switchImage = false;
                }
            }
        }
    }

    public void onActivateRight()
    {
        if (switchImage == false)
        {
            Debug.Log(isHidden);
            if (isHidden)
            {

                imageSlideShow.GetComponent<RectTransform>().localPosition = new Vector3(-Panel.GetComponent<RectTransform>().sizeDelta.x, imageSlideShow.GetComponent<RectTransform>().localPosition.y, imageSlideShow.GetComponent<RectTransform>().localPosition.z);
                isHidden = false;
            }
            else
            {
                isHidden = true;
            }
            prevPos = imageSlideShow.GetComponent<RectTransform>().localPosition;
            switchImage = true;
            isRight = true;
        }
    }
    public void onActivateLeft()
    {
        if (switchImage == false)
        {
            Debug.Log(isHidden);
            if (isHidden)
            {
                imageSlideShow.GetComponent<RectTransform>().localPosition = new Vector3(Panel.GetComponent<RectTransform>().sizeDelta.x, imageSlideShow.GetComponent<RectTransform>().localPosition.y, imageSlideShow.GetComponent<RectTransform>().localPosition.z);
                isHidden = false;
            }
             else
            {
                isHidden = true;
            }
            prevPos = imageSlideShow.GetComponent<RectTransform>().localPosition;
            switchImage = true;
            isRight = false;
        }
    }
}

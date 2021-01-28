using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CurrencyShopMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject otherShopButton;
    public GameObject otherShopButton1;
    public GameObject otherShopButton2;
    public GameObject TestLinked;
    void Start()
    {
        TestLinked = otherShopButton.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(otherShopButton.GetComponent<Button>().interactable == true && otherShopButton.transform.GetChild(1).gameObject.activeInHierarchy == true)
        {
            otherShopButton.transform.GetChild(1).gameObject.SetActive(false);
        }
        else if (otherShopButton.GetComponent<Button>().interactable == false && otherShopButton.transform.GetChild(1).gameObject.activeInHierarchy == false)
        {
            otherShopButton.transform.GetChild(1).gameObject.SetActive(true);
        }
        if (otherShopButton1.GetComponent<Button>().interactable == true && otherShopButton1.transform.GetChild(1).gameObject.activeInHierarchy == true)
        {
            otherShopButton1.transform.GetChild(1).gameObject.SetActive(false);
        }
        else if (otherShopButton1.GetComponent<Button>().interactable == false && otherShopButton1.transform.GetChild(1).gameObject.activeInHierarchy == false)
        {
            otherShopButton1.transform.GetChild(1).gameObject.SetActive(true);
        }
        if (otherShopButton2.GetComponent<Button>().interactable == true && otherShopButton2.transform.GetChild(1).gameObject.activeInHierarchy == true)
        {
            otherShopButton2.transform.GetChild(1).gameObject.SetActive(false);
        }
        else if (otherShopButton2.GetComponent<Button>().interactable == false && otherShopButton2.transform.GetChild(1).gameObject.activeInHierarchy == false)
        {
            otherShopButton2.transform.GetChild(1).gameObject.SetActive(true);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetInteractable : MonoBehaviour
{
    public bool usedOnUsageButton;
    private Button ShopButton;
    public Button startingShopButton;
    public Button otherShopButton1;
    public Button otherShopButton2;
    // Start is called before the first frame update
    void Start()
    {
        if (usedOnUsageButton == true)
        {
            ShopButton = this.gameObject.GetComponent<Button>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeShopPanel()
    {
        if (usedOnUsageButton == true)
        {
            ShopButton.interactable = false;
        }
        else if(usedOnUsageButton == false)
        {
            Debug.Log("Started");
            startingShopButton.interactable = false;
        }
        otherShopButton1.interactable = true;
        otherShopButton2.interactable = true;
    }
}

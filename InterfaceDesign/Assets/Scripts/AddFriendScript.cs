using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AddFriendScript : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setName(Text inputText)
    {
        for (int i = 0; i < this.gameObject.transform.childCount; ++i)
        {
            Debug.Log("ChildCount" + this.gameObject.transform.childCount);
            if (this.gameObject.transform.GetChild(i).GetComponentInChildren<Text>().text == "")
            {
                this.gameObject.transform.GetChild(i).GetComponentInChildren<Text>().text = inputText.text;
                break;
            }
            else
            {
                continue;
            }
        }
       
    }
}

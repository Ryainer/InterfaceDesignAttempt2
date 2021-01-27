using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMGUIScript : MonoBehaviour
{
    private int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 90), "Main Menu");
        GUI.Box(new Rect(Screen.width - 100, Screen.height - 50, 100, 50), "BotRight");
        if(GUI.Button(new Rect(20,40,80,20), number.ToString()))
        {
            number++;
        }
    }
}

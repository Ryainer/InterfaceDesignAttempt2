using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ActivateGameControlScript : MonoBehaviour
{
    private GameObject[] buttons;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ActivateGameButtons()
    {
        if (buttons == null)
            buttons = GameObject.FindGameObjectsWithTag("GameControlButtons");

        foreach (GameObject button in buttons)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
}

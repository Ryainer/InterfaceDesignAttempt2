using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeactivateGameControlsScript : MonoBehaviour
{
    private GameObject[] buttons;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnEnable()
    {
        if (buttons == null)
            buttons = GameObject.FindGameObjectsWithTag("GameControlButtons");

        foreach (GameObject button in buttons)
        {
            button.GetComponent<Button>().interactable = false;
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}

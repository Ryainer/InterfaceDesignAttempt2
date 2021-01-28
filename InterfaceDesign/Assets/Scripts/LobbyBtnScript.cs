using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyBtnScript : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onLobbyBtnPressed()
    {
        if (Panel.activeInHierarchy)
        {
            Panel.SetActive(false);
        }
        else if (!Panel.activeInHierarchy)
        {
            Panel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

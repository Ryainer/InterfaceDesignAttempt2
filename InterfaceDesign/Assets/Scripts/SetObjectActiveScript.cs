using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectActiveScript : MonoBehaviour
{
    public GameObject objectToSetActive;
    public bool SetSelfInactive;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void setObjectActive()
    {

      
        if (objectToSetActive.activeInHierarchy == false)
        {
            objectToSetActive.SetActive(true);
        }
        else
        {
            objectToSetActive.SetActive(false);
        }
        if (SetSelfInactive == true)
        {
            this.gameObject.SetActive(false);
        }
    }
}


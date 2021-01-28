using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSettingsScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }

}

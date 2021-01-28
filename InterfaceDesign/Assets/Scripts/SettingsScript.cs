using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
public class SettingsScript : MonoBehaviour
{

    public AudioMixer audioMixer;
    public Dropdown resolutionDropdown;
    public Dropdown qualityDropdown;
    public Dropdown textureDropdown;
    public Dropdown aaDropdown;
    public Slider volumeSlider;
    float currentVolume;
    Resolution[] resolutions;

    public GameObject Camera;
    public GameObject PostProcessing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeAliasingSetting(int value)
    {
        if(value == 0)
        {
            Camera.GetComponent<PostProcessLayer>().antialiasingMode = PostProcessLayer.Antialiasing.FastApproximateAntialiasing;
        }
        if (value == 1)
        {
            Camera.GetComponent<PostProcessLayer>().antialiasingMode = PostProcessLayer.Antialiasing.SubpixelMorphologicalAntialiasing;
        }
        if (value == 2)
        {
            Camera.GetComponent<PostProcessLayer>().antialiasingMode = PostProcessLayer.Antialiasing.TemporalAntialiasing;
        }
    }
    public void ChangeWeightSettings(float value)
    {
        PostProcessing.GetComponent<PostProcessVolume>().weight = value;
    }
    public void SetVolume(float volume)
    {
        PlayerPrefs.SetFloat("volume", volume);
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}


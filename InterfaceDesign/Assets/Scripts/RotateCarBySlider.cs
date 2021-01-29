using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateCarBySlider : MonoBehaviour
{
    public GameObject Object;
    private float previousValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void rotateObjectXAxis(float value)
    {
        // How much we've changed
        float delta = value - this.previousValue;
        this.Object.transform.Rotate(Vector3.up * delta * 360);

        // Set our previous value for the next change
        this.previousValue = value;
    }
}


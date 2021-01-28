using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakeLightScript : MonoBehaviour
{
    public GameObject lights;
    public Material noBrake;
    public Material Brake;

    public void breakHeldDown()
    {
        if(lights.GetComponent<MeshRenderer>().material != Brake)
        lights.GetComponent<MeshRenderer>().material = Brake;
    }
    public void breakReleased()
    {
        if (lights.GetComponent<MeshRenderer>().material != noBrake)
            lights.GetComponent<MeshRenderer>().material = noBrake;
    }
}

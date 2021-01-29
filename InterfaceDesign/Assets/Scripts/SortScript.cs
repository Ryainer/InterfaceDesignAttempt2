using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortScript : MonoBehaviour
{
    public GameObject GO1;
    public GameObject GO2;

    public GameObject lock1;
    public GameObject lock2;

    // Start is called before the first frame update
    void Start()
    {
        // GO1.GetComponent<WheelData>().level
        // GO1.transform.localPosition = new Vector3(0.0f, 0.0f);
        //GO2.transform.localPosition = new Vector3(0.0f, 0.0f);
        //lock1 = GameObject.Find("Image(4)");
        //lock2 = GameObject.Find("Image(3)");
    }

    public int Comparison()
    {
       int i = GO1.GetComponent<WheelData>().level.CompareTo(GO2.GetComponent<WheelData>().level);
        Debug.Log(i);
        return i;
    }

    public void Sort(int val)
    {
        if(val == 0)
        {
            if (Comparison() == -1)
            {
                GO2.transform.position = lock1.transform.position;
                GO1.transform.position = lock2.transform.position;
                Debug.Log(GO1.transform.localPosition);
                Debug.Log(lock2.transform.localPosition);
            }
            else if (Comparison() == 1)
            {
                GO2.transform.position = lock1.transform.position;
                GO1.transform.position = lock2.transform.position;
                Debug.Log(GO2.transform.localPosition);
                Debug.Log(lock1.transform.localPosition);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayFacture : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       if( GlobalVariable.weekend && GlobalVariable.morning)
        {
            GameObject.Find("UIFactureWeekend").SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

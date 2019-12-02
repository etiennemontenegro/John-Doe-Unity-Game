using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhenDisabled : MonoBehaviour
{
    void OnDisable()
    {
        Debug.Log("PrintOnDisable: script was disabled");        
        GlobalVariable.menuWasSeen = true; 
    }   
}

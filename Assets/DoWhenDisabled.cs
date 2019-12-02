using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhenDisabled : MonoBehaviour
{
    void OnDisable()
    {
        Debug.Log("PrintOnDisable: script was disabled");
        GameObject.Find("MenuUI").GetComponent<CheckMenuActive>().menuIsActive = false;
        GlobalVariable.menuWasSeen = true;
    }   
}

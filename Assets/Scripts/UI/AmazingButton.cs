using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmazingButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject store;

    void Awake()
    {
        store = GameObject.Find("StoreUI");
    }

    public void OnClick()
    {
        Debug.Log("INTHESCRIPTYO");
        store.SetActive(true);
        GlobalVariable.inStore = true;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class night : MonoBehaviour
{
   public GameObject myOb;
    Color maco;
    // Start is called before the first frame update
    void Start()
    {
        myOb = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
       maco = myOb.GetComponent<SpriteRenderer>().color;

        if(GlobalVariable.morning == true) GetComponent<SpriteRenderer>().color = new Color(0, 0, 0,.0f);

        if (GlobalVariable.morning == false) GetComponent<SpriteRenderer>().color = new Color(0, 0, .2f, .6f);

    }
}

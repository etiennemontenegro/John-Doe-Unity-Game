using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textFacture : MonoBehaviour
{
    Text txt;
    //private int currentscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        txt.text = "Paye : " + GlobalVariable.paycheck;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyMontant01 : MonoBehaviour
{
    Text txt01;
    //private int currentscore = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        txt01 = gameObject.GetComponent<Text>();
        txt01.text = "Hydro Kebek: -" + MoneyManagment.montant1;
    }
}

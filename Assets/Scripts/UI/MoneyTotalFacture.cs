using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyTotalFacture : MonoBehaviour
{
    Text txtTotal;

    void Start()
    {
        txtTotal = gameObject.GetComponent<Text>();
        txtTotal.text = "Gros total : " + MoneyManagment.total;
    }
}

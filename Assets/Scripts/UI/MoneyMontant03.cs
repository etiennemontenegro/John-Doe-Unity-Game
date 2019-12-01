using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyMontant03 : MonoBehaviour
{
    Text txt03;

    void Update()
    {
        txt03 = gameObject.GetComponent<Text>();
        txt03.text = "Netflikse: -" + MoneyManagment.montant3;
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyMontant02 : MonoBehaviour
{
    Text txt02;

    void Update()
    {
        txt02 = gameObject.GetComponent<Text>();
        txt02.text = "Appart trop cher: -" + MoneyManagment.montant2;
    }

}

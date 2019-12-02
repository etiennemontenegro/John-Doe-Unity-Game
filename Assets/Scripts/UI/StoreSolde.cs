using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreSolde : MonoBehaviour
{
    public static int solde = GlobalVariable.wallet;
    private int prevOrderAmount = 0;

    private Color red = Color.red;
    private Color grey = new Color(0.5f, 0.5f, 0.5f);

    void Start()
    {
        this.gameObject.GetComponent<Text>().text = solde.ToString();
    }

    void OnEnable()
    {
        this.gameObject.GetComponent<Text>().text = GlobalVariable.wallet.ToString();
    }


    void Update()
    {
        if(prevOrderAmount != StoreCommandeAmount.orderAmount)
        {
            solde = GlobalVariable.wallet;
            solde -= StoreCommandeAmount.orderAmount;
            this.gameObject.GetComponent<Text>().text = solde.ToString();

            if (int.Parse(this.gameObject.GetComponent<Text>().text) < 0)
            {
                this.gameObject.GetComponent<Text>().color = red;
            }
            else
            {
                this.gameObject.GetComponent<Text>().color = grey;
            }

            prevOrderAmount = StoreCommandeAmount.orderAmount;
        }

    }
}

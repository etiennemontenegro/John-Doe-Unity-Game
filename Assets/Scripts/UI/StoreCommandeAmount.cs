using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreCommandeAmount : MonoBehaviour
{
    public static int orderAmount = 0;

    void Start()
    {
        this.gameObject.GetComponent<Text>().text = orderAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(orderAmount != InventoryManager.totalPrice)
        {
            orderAmount = InventoryManager.totalPrice;
            this.gameObject.GetComponent<Text>().text = orderAmount.ToString();
        }
    }
}

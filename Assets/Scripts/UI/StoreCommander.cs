using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreCommander : MonoBehaviour
{
    private GameObject StoreRef;
    private GameObject Store;
    private List<string> namesTabarnak;

    public static List<StoreItems> purchasedItems = new List<StoreItems>();

    void Start()
    {
        StoreRef = GameObject.Find("StoreWindow");
        Store = GameObject.Find("StoreUI");
        namesTabarnak = GameObject.Find("StoreWindow").GetComponent<InventoryManager>().selectedItemNames;
    }

    void Update()
    {
        if(StoreSolde.solde < 0 && this.gameObject.GetComponent<Button>().interactable == true)
        {
            this.gameObject.GetComponent<Button>().interactable = false;
        }
        else if(StoreSolde.solde >= 0 && this.gameObject.GetComponent<Button>().interactable == false)
        {
            this.gameObject.GetComponent<Button>().interactable = true;
        }
    }

    public void OnClick()
    {
        OrderMyShit();
    }

    void OrderMyShit()
    {
        if(purchasedItems != null)
        {
            purchasedItems.Clear();
        }
        foreach(string orderedItems in namesTabarnak)
        {
            for(int i =0; i < 30; i++)
            {
                if(StoreRef.GetComponent<StoreSetup>().storeItems[i].itemName == orderedItems)
                {
                    purchasedItems.Add(StoreRef.GetComponent<StoreSetup>().storeItems[i]);
                }
            }
        }

        foreach(StoreItems setPurchased in purchasedItems)
        {
            setPurchased.purchased = true;
        }

        GlobalVariable.wallet -= StoreSolde.solde;

        for(int i = 0; i < 30; i++)
        {
            Debug.Log(StoreRef.GetComponent<StoreSetup>().storeItems[i].purchased);
        }
    }
}

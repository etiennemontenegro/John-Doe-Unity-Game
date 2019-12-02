using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreCommander : MonoBehaviour
{
    private GameObject StoreRef;
    private GameObject Store;
    private List<string> namesTabarnak;
    public GameObject PopUpOrder;

    public static List<StoreItems> purchasedItems = new List<StoreItems>();

    void Awake()
    {
        PopUpOrder = GameObject.Find("PopUpOrder");
        Store = GameObject.Find("StoreUI");
    }

    void Start()
    {
        StoreRef = GameObject.Find("StoreWindow");
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
        PopUpOrder.SetActive(true);
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
    }
}

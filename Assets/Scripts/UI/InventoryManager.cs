using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryManager : MonoBehaviour
{
    public List<StoreItemBox> storeDisplayItems;

    public bool displayStoreItems = false;

    private GameObject StoreRef;

    [SerializeField]
    public Sprite[] objectAssets;

    [SerializeField]
    private GameObject itemTemplate;

    void Start() // Should be onEnable?
    {
        storeDisplayItems = new List<StoreItemBox>();

        //Debug.Log("InventoryManager Running now (Should be Last)");

        StoreRef = GameObject.Find("StoreWindow");

        for (int i = 0; i < 30; i++)
        {
            StoreItemBox newItem = new StoreItemBox();
            if (StoreRef.GetComponent<StoreSetup>().storeItems[i].purchased == false)
            {
                storeDisplayItems.Add(newItem);
                storeDisplayItems[i].itemSprite = StoreRef.GetComponent<StoreSetup>().storeItems[i].itemSprite;
                storeDisplayItems[i].itemName = StoreRef.GetComponent<StoreSetup>().storeItems[i].itemName;
                storeDisplayItems[i].itemPrice = StoreRef.GetComponent<StoreSetup>().storeItems[i].price;
            }
        }

        GenerateStoreInventory();
    }

    void GenerateStoreInventory()
    {
        foreach (StoreItemBox newStoreItem in storeDisplayItems)
        {
            GameObject newItem = Instantiate(itemTemplate) as GameObject;
            newItem.SetActive(true);

            newItem.GetComponent<StoreItemHandler>().SetAttributes(newStoreItem.itemSprite, newStoreItem.itemName, newStoreItem.itemPrice);

            newItem.transform.SetParent(itemTemplate.transform.parent, false);
        }
    }

}

public class StoreItemBox
{
    public Sprite itemSprite;
    public string itemName;
    public int itemPrice;
}

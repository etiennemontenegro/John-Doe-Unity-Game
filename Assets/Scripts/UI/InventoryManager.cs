using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Script that populates the Store Window on store load 
// as well as managing player interaction with the inventory.

public class InventoryManager : MonoBehaviour
{
    public List<StoreItemBox> storeDisplayItems;    // List of items to display in the store
    public List<GameObject> storeAllItems;          // List of all items displayed in store as GameObjects
    public List<GameObject> selectedItems;          // List of selected items as GameObjects
    public List<string> selectedItemNames;          // List of selected items by name

    public static int totalPrice = 0;

    public static bool closeShits = false;

    private GameObject StoreRef;
    public StoreItems[] itemsAgain;

    [SerializeField]
    public Sprite[] objectAssets;

    [SerializeField]
    private GameObject itemTemplate;

    void OnEnable() // OnEnable to populate whenever the Store is opened
    {
        storeDisplayItems = new List<StoreItemBox>();

        StoreRef = GameObject.Find("StoreWindow");

        if(GlobalVariable.startGame)
        {
            for (int i = 0; i < 30; i++)
            {
                StoreItemBox newItem = new StoreItemBox();

                storeDisplayItems.Add(newItem);
                storeDisplayItems[i].itemSprite = GlobalVariable.storeItems[i].itemSprite;
                storeDisplayItems[i].itemName = GlobalVariable.storeItems[i].itemName;
                storeDisplayItems[i].itemPrice = GlobalVariable.storeItems[i].price;
                storeDisplayItems[i].purchased = GlobalVariable.storeItems[i].purchased;
            }

            GenerateStoreInventory();
        }
    }

    void Start()
    {
        itemsAgain = GlobalVariable.storeItems;
    }

    void Update()
    {
        foreach(GameObject storeItemElement in storeAllItems)
        {
            string myName = storeItemElement.GetComponent<StoreItemHandler>().LocalNameLabel.text.ToString();
            int myPrice = int.Parse(storeItemElement.GetComponent<StoreItemHandler>().LocalitemPrice.text.ToString());

            if (storeItemElement.GetComponent<Toggle>().isOn == true)
            {
                if(selectedItemNames.Contains(myName))
                {

                }
                else
                {
                    selectedItems.Add(storeItemElement);
                    selectedItemNames.Add(myName);
                    totalPrice += myPrice;
                }
            }
            else if(storeItemElement.GetComponent<Toggle>().isOn == false)
            {
                if(selectedItemNames.Contains(myName))
                {
                    selectedItemNames.Remove(myName);
                    selectedItems.Remove(storeItemElement);
                    totalPrice -= myPrice;
                }
            }
        }

        if(closeShits)
        {
            CloseStore();
            closeShits = false;
        }
    }

    void GenerateStoreInventory() // Populates the Store Window
    {
        foreach (StoreItemBox newStoreItem in storeDisplayItems)
        {
            GameObject newItem = Instantiate(itemTemplate) as GameObject;
            newItem.SetActive(true);

            newItem.GetComponent<StoreItemHandler>().SetAttributes(newStoreItem.itemSprite, newStoreItem.itemName, newStoreItem.itemPrice);

            newItem.transform.SetParent(itemTemplate.transform.parent, false);

            if (newStoreItem.purchased)
            {
                newItem.GetComponent<Toggle>().interactable = false;
            }

            storeAllItems.Add(newItem); 
        }
    }

    void OnDisable()
    {
        DeleteEverything();
    }

    void DeleteEverything()
    {
        if(storeAllItems.Count > 0)
        {
            foreach(GameObject item in storeAllItems)
            {
                Destroy(item.gameObject);
            }
        }

        storeAllItems.Clear();
        storeDisplayItems.Clear();
    }

    void CloseStore()
    {
        StoreInventory.storeCopyDone = false;
        for(int i = 0; i < 30; i++)
        {
            StoreInventory.CopyStoreInventory(itemsAgain[i]);
        }
        StoreInventory.storeCopyDone = true;
        GameObject.Find("StoreUI").SetActive(false);
    }
}

public class StoreItemBox // Class & properties for an item box in the Store Window
{
    public Sprite itemSprite;
    public string itemName;
    public int itemPrice;
    public bool purchased;
}

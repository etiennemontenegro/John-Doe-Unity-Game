using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreInventory : MonoBehaviour
{
    public static List<StoreItems> storeCopy = new List<StoreItems>();
    public static bool storeCopyDone = false;

    public GameObject Store;
    public GameObject newStore;
    public GameObject MessageOne;
    public GameObject MessageTwo;
    public bool PurchasesItemIndex;

    public GameObject TV;
    //public Sprite newSpriteElement;




    void Start()
    {
        Store = GameObject.Find("StoreUI");
        //newStore = GameObject.Find("StoreWindow");
        MessageOne = GameObject.Find("PopUpYouSuck");
        MessageTwo = GameObject.Find("PopUpOrder");


        MessageTwo.SetActive(false);
        MessageOne.SetActive(false);
        Store.SetActive(false);

       //TV.GetComponent<SpriteRenderer>().sprite = newStore.GetComponent<StoreSetup>().storeItems[0].itemSprite;

        for (int i = 0; i <= 29; i++)
        {

            PurchasesItemIndex = newStore.GetComponent<StoreSetup>().storeItems[i].purchased;

            if (PurchasesItemIndex = newStore.GetComponent<StoreSetup>().storeItems[i].purchased == false)
            {
                break;
            }
            else {

                if (i == 0) {
                    TV.GetComponent<SpriteRenderer>().sprite = newStore.GetComponent<StoreSetup>().storeItems[0].itemSprite;
                }
            
            }
        }

    }

    private void Update()
    {

        /* ============================
         ========= TV =================
         =========================== */



    }


    public static void CopyStoreInventory(StoreItems original)
    {
        if (!storeCopyDone)
        {
            storeCopy.Add(original);
        }
    }
}

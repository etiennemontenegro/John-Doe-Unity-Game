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


    void Awake()
    {
        Store = GameObject.Find("StoreUI");
        newStore = GameObject.Find("StoreWindow");
        MessageOne = GameObject.Find("PopUpYouSuck");
        MessageTwo = GameObject.Find("PopUpOrder");
    }

    void Start()
    {
        //Debug.Log(newStore.GetComponent<StoreSetup>().storeItems[0].purchased);
        


        MessageTwo.SetActive(false);
        MessageOne.SetActive(false);
        Store.SetActive(false);

       //TV.GetComponent<SpriteRenderer>().sprite = newStore.GetComponent<StoreSetup>().storeItems[0].itemSprite;
       if(GlobalVariable.startGame)
        {
            for (int i = 0; i <= 29; i++)
            {

                if (i == 0 && GlobalVariable.storeItems[i].purchased)
                {
                    TV.GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[0].itemSprite;
                }

            }
        }
    }

    private void Update()
    {
        //Debug.Log(GlobalVariable.storeItems[0].purchased);
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

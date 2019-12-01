using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreInventory : MonoBehaviour
{
    public static List<StoreItems> storeCopy = new List<StoreItems>();
    public static bool storeCopyDone = false;

    public GameObject Store;
    public GameObject MessageOne;
    public GameObject MessageTwo;

    void Start()
    {
        Store = GameObject.Find("StoreUI");
        MessageOne = GameObject.Find("PopUpYouSuck");
        MessageTwo = GameObject.Find("PopUpOrder");

        MessageTwo.SetActive(false);
        MessageOne.SetActive(false);
        Store.SetActive(false);
    }

    public static void CopyStoreInventory(StoreItems original)
    {
        if(!storeCopyDone)
        {
            storeCopy.Add(original);
        }
    }
}

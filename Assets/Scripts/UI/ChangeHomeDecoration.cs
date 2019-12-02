using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHomeDecoration : MonoBehaviour
{

    public GameObject TV;
    public Sprite newSpriteElement;


    public bool isBought = true;

    public GameObject oldStore;
   // public GameObject newStore;

    // Start is called before the first frame update
    void Start()
    {

        oldStore = GameObject.Find("StoreUI");
        newSpriteElement = oldStore.GetComponent<StoreSetup>().storeItems[0].itemSprite;

        if (isBought == true)
        {
            TV.GetComponent<SpriteRenderer>().sprite = newSpriteElement;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

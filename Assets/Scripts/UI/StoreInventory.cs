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

    public GameObject[] achats;
    public Sprite [] wallSprite;
    public Sprite[] groundSprite;
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
        if (GlobalVariable.jeuEnMarche)
        {
            //-------------------------------------------TV
            for (int i = 0; i <= 2; i++)
            {

                // Debug.Log(GlobalVariable.storeItems[i].itemName);
                if (i == 0 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[0].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }

                if (i == 1 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[0].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }

                if (i == 2 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[0].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }
            }
            //-------------------------------------------LIGHTS
            for (int i = 3; i <= 4; i++)
            {

                // Debug.Log(GlobalVariable.storeItems[i].itemName);
                if (i == 3 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[1].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }

                if (i == 4 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[1].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }

            }


            for (int i = 5; i <= 7; i++)
            {

                //-------------------------------------------TABLES
                if (i == 5 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[2].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }

                if (i == 6 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[2].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }

                if (i == 7 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[2].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }

            }


            for (int i = 8; i <= 9; i++)
            {

                //-------------------------------------------MUR
                if (i == 8 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[3].GetComponent<SpriteRenderer>().sprite =  wallSprite[0];
                }

                if (i == 9 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[3].GetComponent<SpriteRenderer>().sprite = wallSprite[1];
                }





            }



            for (int i = 10; i <= 12; i++)
            {

                //-------------------------------------------POSTERS
                if (i == 10 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[4].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }

                if (i == 11 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[4].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }

                if (i == 12 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[4].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }


            }




            for (int i = 13; i <= 15; i++)
            {

                //-------------------------------------------Chair
                if (i == 13 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[5].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }

                if (i == 14 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[5].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }


                if (i == 15 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[5].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }
            }


            for (int i = 16; i <= 17; i++)
            {

                //-------------------------------------------plancher
                if (i == 16 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[6].GetComponent<SpriteRenderer>().sprite = groundSprite[0];
}

                if (i == 17 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[6].GetComponent<SpriteRenderer>().sprite  = groundSprite[1];
                }

            }


            for (int i = 18; i <= 18; i++)
            {

                //-------------------------------------------plante1
                if (i == 18 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[7].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }


            }

            for (int i = 19; i <= 19; i++)
            {

                //-------------------------------------------plante2
                if (i == 19 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[8].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }


            }


            for (int i = 20; i <= 20; i++)
            {

                //-------------------------------------------trohpy1
                if (i == 20 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[9].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }


            }



            for (int i = 21; i <= 21; i++)
            {

                //-------------------------------------------trohpy2
                if (i == 21 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[10].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }


            }


            //-------------------------------------------sofa
            for (int i = 22; i <= 24; i++)
            {

               
                if (i == 22 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[11].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }

           
                if (i == 23 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[11].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }

             
                if (i == 24 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[11].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }

            }


            //-------------------------------------------bed
            for (int i = 25; i <= 27; i++)
            {


                if (i == 25 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[12].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }


                if (i == 26 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[12].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }


                if (i == 27 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[12].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }

            }


            //-------------------------------------------fridge
            for (int i = 28; i <= 28; i++)
            {


                if (i == 28 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[13].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
                }
            }

            for (int i = 29; i <= 29; i++)
            {


                if (i == 29 && GlobalVariable.storeItems[i].purchased)
                {
                    achats[14].GetComponent<SpriteRenderer>().sprite = GlobalVariable.storeItems[i].itemSprite;
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

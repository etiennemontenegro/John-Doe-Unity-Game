using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// Ajouter comparation de qualité si 2 items de meme  familles sont acheter par le joeur.
/// la qualitté la plus haute l'emporte

public class Switch_decoration_Home : MonoBehaviour
{

    public GameObject myStoreWindow;
    private int newStore;
    private int storeStore;

    private bool TriggerDetection;

    public int maxIndex;
    public bool isBought;

    public GameObject[] Fridge;
    static public int activeIndexFridge = 0;

    public GameObject[] Chair;
    static public int activeIndexChair = 0;

    public GameObject[] Table;
    static public int activeIndexTable = 0;

    public GameObject[] TV; 
    static public int activeIndexTV = 1;

    public GameObject[] Tablette;
    static public int activeIndexTablette = 0;

    public GameObject[] Sofa;
    static public int activeIndexSofa = 0;

    public GameObject[] Bed;
    static public int activeIndexBed = 0;

    public GameObject[] TabletteTV;
    static public int activeIndexTabletteTV = 0;

    public GameObject[] Etagere;
    static public int activeIndexEtagere = 0;

    public GameObject[] Lamp;
    static public int activeIndexLamp = 2; 

    //public GameObject[] Poster;
    //static public int activeIndexPoster = 0;


    // Start is called befxore the first frame update
    void Start()
    {
        newStore =  myStoreWindow.GetComponent<StoreSetup>().storeItems[0].quality - 1;
     

    }

    // Update is called once per frame
    void Update()
    {
        SwitchElementsTV(activeIndexTV);
        SwitchElementsChair(activeIndexChair);
        SwitchElementsTable(activeIndexTable);
        SwitchElementsFridge(activeIndexFridge);
        SwitchElementsLamp(activeIndexLamp);
        SwitchElementsSofa(activeIndexSofa);
        SwitchElementsBed(activeIndexBed);
        //SwitchElementsPoster(activeIndexPoster);
        SwitchElementsTablette(activeIndexTablette);
        SwitchElementsEtagere(activeIndexEtagere);
        SwitchElementsTabletteTV(activeIndexTabletteTV);

        if (TriggerDetection == false) {
            DetectElements();
        }
        

    }

    public void DetectElements()
    {

        //Detect if any item is purchase;
        for (int i = 0; i <= 29; i++)
        {

            isBought = myStoreWindow.GetComponent<StoreSetup>().storeItems[i].purchased;
            //Debug.Log(isBought);

            TriggerDetection = true;

        }


    }

    public void SwitchElementsTV(int aIndex) {

        activeIndexTV = aIndex;

        for (int i = 0; i <= TV.Length-1; i++) {

            TV[i].SetActive(i == activeIndexTV);
        }

    }

    public void SwitchElementsChair(int aIndex)
    {

        activeIndexChair = aIndex;

        for (int i = 0; i <= Chair.Length - 1; i++)
        {

            Chair[i].SetActive(i == activeIndexChair);
        }

    }


    public void SwitchElementsTable(int aIndex)
    {

        activeIndexTable = aIndex;

        for (int i = 0; i <= Table.Length - 1; i++)
        {

            Table[i].SetActive(i == activeIndexTable);
        }

    }

    public void SwitchElementsFridge(int aIndex)
    {

        activeIndexFridge = aIndex;

        for (int i = 0; i <= Fridge.Length - 1; i++)
        {

            Fridge[i].SetActive(i == activeIndexFridge);
        }

    }



    public void SwitchElementsLamp(int aIndex)
    {

        activeIndexLamp = aIndex;

        for (int i = 0; i <= Lamp.Length - 1; i++)
        {

            Lamp[i].SetActive(i == activeIndexLamp);
        }

    }


    public void SwitchElementsSofa(int aIndex)
    {

        activeIndexSofa = aIndex;

        for (int i = 0; i <= Sofa.Length - 1; i++)
        {

            Sofa[i].SetActive(i == activeIndexSofa);
        }

    }

    public void SwitchElementsBed(int aIndex)
    {

        activeIndexBed = aIndex;

        for (int i = 0; i <= Bed.Length - 1; i++)
        {

            Bed[i].SetActive(i == activeIndexBed);
        }

    }

    /*public void SwitchElementsPoster(int aIndex)
    {

        activeIndexPoster = aIndex;

        for (int i = 0; i <= Poster.Length - 1; i++)
        {

            Poster[i].SetActive(i == activeIndexPoster);
        }

    }*/

    public void SwitchElementsTablette(int aIndex)
    {

        activeIndexTablette = aIndex;

        for (int i = 0; i <= Tablette.Length - 1; i++)
        {

            Tablette[i].SetActive(i == activeIndexTablette);
        }

    }


    public void SwitchElementsEtagere(int aIndex)
    {

        activeIndexEtagere = aIndex;

        for (int i = 0; i <= Etagere.Length - 1; i++)
        {

            Etagere[i].SetActive(i == activeIndexEtagere);
        }

    }



    public void SwitchElementsTabletteTV(int aIndex)
    {

        activeIndexTabletteTV = aIndex;

        for (int i = 0; i <= TabletteTV.Length - 1; i++)
        {

            TabletteTV[i].SetActive(i == activeIndexTabletteTV);
        }

    }


   


}

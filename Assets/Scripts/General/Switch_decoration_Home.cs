using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_decoration_Home : MonoBehaviour
{

   
    public GameObject[] TV; 
    static public int activeIndexTV = 1;

    public GameObject[] Chair;
    static public int activeIndexChair = 1;

    public GameObject[] Table;
    static public int activeIndexTable = 1;

    public GameObject[] Fridge;
    static public int activeIndexFridge = 1;

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        SwitchElementsTV(activeIndexTV);
        SwitchElementsChair(activeIndexChair);
        SwitchElementsTable(activeIndexTable);
        SwitchElementsFridge(activeIndexFridge);
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



}

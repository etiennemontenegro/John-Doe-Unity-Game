using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_decoration_Home : MonoBehaviour
{

   
    public GameObject[] tables;
    public GameObject[] fridges;
    public GameObject[] chairs;
    public GameObject[] TV;
    public GameObject[] sofas;
    public GameObject[] beds;
    static public int activeIndexTable = 1;

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        SwitchElementsTable(activeIndexTable);
    }

    public void SwitchElementsTable(int aIndex) {

        activeIndexTable = aIndex;

        for (int i = 0; i <= tables.Length-1; i++) {

            tables[i].SetActive(i == activeIndexTable);
        }

    }


}

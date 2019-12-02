using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject Work,Home;
    public GameObject SpawnedObject;
    int check = 0;
    public AudioSource[] pubRandom;
    public AudioSource[] finDeShift;


    static public int amountPubs;
    
    static public bool hasSpawned = false;
    static public bool hasArrived;


    // Start is called before the first frame update
    void Start()
    {

    }

    void fernandoPiselli()
    {
        pubRandom[Random.Range(0, pubRandom.Length)].Play();
    }

    // Update is called once per frame
    void Update()
    {
       
        hasArrived = GlobalVariable.hasArrived;
  



        if (!hasSpawned)
        {
            check = 0;
            if (hasArrived && !playerHandler.isNight)
            {
                Instantiate(Work);
                Destroy(this);
                return;
            }

            if (hasArrived && playerHandler.isNight)
            {
                Instantiate(Home);
                Destroy(this);
                return;
            }

            if (playerHandler.isNight)
            {
                finDeShift[Random.Range(0, finDeShift.Length)].Play();
            }
           
            Instantiate(SpawnedObject);
            
            hasSpawned = true;
            check = 1;
            


        }
        if (check == 1) { Invoke("fernandoPiselli", 5); check = 0; }

        

    }

  
}
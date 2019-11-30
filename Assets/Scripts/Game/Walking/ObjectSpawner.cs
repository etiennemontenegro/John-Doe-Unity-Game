using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject Work,Home;
    public GameObject SpawnedObject;
    static public int amountPubs;
    
    static public bool hasSpawned = false;
    static public bool hasArrived;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    hasArrived = GlobalVariable.hasArrived;




        if (!hasSpawned)
        {

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

            Instantiate(SpawnedObject);
            hasSpawned = true;
        }




    }

  
}
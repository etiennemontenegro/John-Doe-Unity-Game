using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject Work;
    public GameObject SpawnedObject;
    static public int amountPubs;
    
    static public bool hasSpawned = false;
    public bool hasArrived = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        if (!hasSpawned)
        {

            if (hasArrived)
            {
                Instantiate(Work);
                Destroy(this);
                return;
            }

            Instantiate(SpawnedObject);
            hasSpawned = true;
        }




    }

  
}
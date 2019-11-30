using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject SpawnedObject;
    public bool hasSpawned = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!hasSpawned)
        {
            Instantiate(SpawnedObject);
            hasSpawned = true;
        }


    }

  
}
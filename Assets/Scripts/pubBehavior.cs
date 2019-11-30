using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pubBehavior : MonoBehaviour
{
    private GameObject pub;
    private float moveSpeed =.05f;
    public bool hasSpawned = false;
    public bool HasClicked = true;
    private bool HitPlayer = false;
    public int pubNumber;
    public GameObject handler;

    // Start is called before the first frame update
    void Start()
    {
      
        pubNumber = Random.Range(1,10);
        pub = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        pub.transform.Translate(-1*moveSpeed, 0, 0);
        if (pub.transform.position.x< -30)
        {

            ObjectSpawner.hasSpawned = false;

            Destroy(pub);
        }

        if (!HasClicked)
        {
            moveSpeed = 0;

        }

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
                HitPlayer = true;
                Debug.Log(pubNumber);
            }
          //PlaySound of pub here 


        }
    }





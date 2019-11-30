using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pubBehavior : MonoBehaviour
{
    private GameObject pub;
   

    public float moveSpeed =.1f;
    private bool HitPlayer = false;
    private bool IsMorning=false,IsNight=false;
    public bool hasSpawned = false;
    public bool HasClicked = true;
    public int pubNumber;


    // Start is called before the first frame update
    void Start()
    {
     

        if (IsNight)
        {
            moveSpeed = moveSpeed * -1;
            pub.transform.position = new Vector3(transform.position.x * -1, transform.position.y, transform.position.z);

        }
        pub = gameObject;
    


        pubNumber = Random.Range(1,10);
      ;
    }

    // Update is called once per frame
    void Update()
    {
        pub.transform.Translate(-1*moveSpeed, 0, 0);
        if (pub.transform.position.x< -30)
        {

            ObjectSpawner.hasSpawned = false;
            ObjectSpawner.amountPubs++;
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
                 //PlaySound of pub here 
        }



    }
    }





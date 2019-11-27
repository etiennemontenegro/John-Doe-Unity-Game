using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pubBehavior : MonoBehaviour
{
    private GameObject pub;
    private float moveSpeed =.1f;
    public bool hasSpawned = false;
    public bool HasClicked = true;
    // Start is called before the first frame update
    void Start()
    {
        pub = gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        pub.transform.Translate(-1*moveSpeed, 0, 0);
        if (pub.transform.position.x< -11)
        {
            Destroy(pub);
        }

        if (!HasClicked)
        {
            moveSpeed = 0;

        }


        if (HasClicked)
        {
            moveSpeed = .1f;

        }

        if (Input.touchCount > 0)
        {
            HasClicked = true;
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        HasClicked = false;
        Debug.Log("I am reading");
        

    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using TMPro;
public class pubBehavior : MonoBehaviour
{
    public GameObject canvas;
    public GameObject handler;
    public GameObject drawing;
    private GameObject handlerChild,pub;


    private string myObjectValue;

    public float moveSpeed =.05f;
    private bool HitPlayer = false;
    private bool IsMorning=false,IsNight=false;
    public bool hasSpawned = false;
    public bool HasClicked = true;
    public int pubNumber,maxDist = 20;
    public TextMeshProUGUI TextPro;
 

    // Start is called before the first frame update
    void Start()
    {
        pubNumber = Random.Range(0, 29);


        // handler = GameObject.Find("StoreWindow");
        //Debug.Log(handler.GetComponent<StoreSetup>().storeItems[0].price);
        myObjectValue = handler.GetComponent<StoreSetup>().storeItems[pubNumber].price.ToString() + "$ wow!";
        drawing.GetComponent<SpriteRenderer>().sprite = handler.GetComponent<StoreSetup>().storeItems[pubNumber].itemSprite;
        TextPro.text = myObjectValue;

        canvas.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0, 1f), 1);


        pub = gameObject;
        IsNight = playerHandler.isNight;
        if (IsNight)
        {
            moveSpeed = moveSpeed * -1;
            pub.transform.position = new Vector3(transform.position.x * -1, transform.position.y, transform.position.z);

        }
     
    


    
      ;
    }

    // Update is called once per frame
    void Update()
    {

        


        pub.transform.Translate(-1*moveSpeed, 0, 0);
        if (pub.transform.position.x< -maxDist|| pub.transform.position.x>maxDist )
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
                 //----------------------------------------PlaySound of pub here 
        }



    }
    }





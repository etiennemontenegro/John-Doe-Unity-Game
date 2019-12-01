using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHandler : MonoBehaviour
{
    public GameObject player;
    static public bool isNight;

    public GameObject bg; 
    static public bool isScrolling = true;
    // Start is called before the first frame update
    void Start()

    {
        isScrolling = true;
       // GlobalVariable.walkToWork = true;
        isNight = !GlobalVariable.morning;
       if(isNight)player.transform.position = new Vector3(player.transform.position.x * -1, player.transform.position.y, player.transform.position.z);

       if(GlobalVariable.morning == true)
        {
            GameObject.Find("JohnDoe_Walking").GetComponent<Animator>().SetBool("WalkingBack", false);
        } else
        {
            GameObject.Find("JohnDoe_Walking").GetComponent<Animator>().SetBool("WalkingBack", true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isScrolling && !isNight) bg.transform.position = new Vector3(bg.transform.position.x - .05f, bg.transform.position.y, bg.transform.position.z);
        if (isScrolling && isNight) bg.transform.position = new Vector3(bg.transform.position.x + .05f, bg.transform.position.y, bg.transform.position.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHandler : MonoBehaviour
{
    public GameObject player;
    static public bool isNight;
    // Start is called before the first frame update
    void Start()

    {
        isNight = true;
       if(isNight)player.transform.position = new Vector3(player.transform.position.x * -1, player.transform.position.y, player.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

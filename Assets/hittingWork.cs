using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hittingWork : MonoBehaviour
{
   private GameObject work,player;
    private float moveSpeed = .05f;
    // Start is called before the first frame update
    void Start()
    {
        work = gameObject;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (work.transform.position.x > 8)
            work.transform.Translate(-1 * moveSpeed, 0, 0);
        else
        {
            player.transform.position = new Vector3(player.transform.position.x + .05f, player.transform.position.y, player.transform.position.z);
        }
    }

}

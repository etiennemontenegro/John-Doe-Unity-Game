﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hittingHome : MonoBehaviour
{
   private GameObject home,player;
    private float moveSpeed = .05f;
    // Start is called before the first frame update
    void Start()
    {
        home = gameObject;

        player = GameObject.FindGameObjectWithTag("Player");



    }

    // Update is called once per frame
    void Update()
    {
        if (home.transform.position.x < -8)
            home.transform.Translate(1 * moveSpeed, 0, 0);
        else
        {
            player.transform.position = new Vector3(player.transform.position.x - .05f, player.transform.position.y, player.transform.position.z);
        }
    }

}
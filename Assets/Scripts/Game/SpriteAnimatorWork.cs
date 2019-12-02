﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimatorWork : MonoBehaviour
{
    [SerializeField] private Sprite[] frameArray;
    private int currentFrame;
    private float timer;
    private float framerate = 0.4f;

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= framerate)
        {
            timer -= framerate;
            currentFrame = (currentFrame + 1)% frameArray.Length;
            gameObject.GetComponent<SpriteRenderer>().sprite = frameArray[currentFrame];
        }
    }
}

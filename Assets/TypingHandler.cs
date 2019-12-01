using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypingHandler : MonoBehaviour
{
    private Animator typingAnim;

    void Start()
    {
        typingAnim = GetComponent<Animator>();
        typingAnim.speed = 0f;
        typingAnim.Play("JohnDoeTyping", 0, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

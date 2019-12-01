using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnDoeSpawnHome : MonoBehaviour
{
    private float facingSide;
    private float scaleX;

    void Start()
    {      
        gameObject.transform.position = new Vector3(Random.Range(-7.5f, 7.5f), -4.75f, 0);

        facingSide = Random.Range(-1f, 1f);
        if (facingSide > 0)
        {
            scaleX = 0.8f;
        } else
        {
            scaleX = -0.8f;            
        }
        gameObject.transform.localScale = new Vector3(scaleX, 0.8f, 1);
    }
}

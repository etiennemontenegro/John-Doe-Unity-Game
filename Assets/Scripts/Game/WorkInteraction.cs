using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkInteraction : MonoBehaviour
{

  public static int count = 0;
    private float typeCycle = 0;
    public AudioSource[] randomType;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        count++;
        randomType[Random.Range(0, randomType.Length)].Play();
        if (typeCycle < 11)
        {
            typeCycle++;
        } 
        else
        {
            typeCycle = 0;
        }
        Debug.Log("Count:" + count);
        

        if(typeCycle > 4 && typeCycle < 8)
        {
            //GameObject.Find("JohnDoeTyping").GetComponent<Animator>().Play("JohnDoeTyping", 0, 0.45f);
            GameObject.Find("JohnDoeTyping").GetComponent<Animator>().Play("JohnDoeTyping", 0, typeCycle / 10f - 0.05f);
        } else if(typeCycle > 7 && typeCycle < 11)
        {            
            GameObject.Find("JohnDoeTyping").GetComponent<Animator>().Play("JohnDoeTyping", 0, typeCycle / 10f - 0.1f);
        } else if(typeCycle == 11){
            GameObject.Find("JohnDoeTyping").GetComponent<Animator>().Play("JohnDoeTyping", 0, typeCycle / 10f - 0.15f);
        }
        else
        {           
            GameObject.Find("JohnDoeTyping").GetComponent<Animator>().Play("JohnDoeTyping", 0, typeCycle / 10f);
        }      
    }

  public void UpdatePaycheck()
    {
        
        GlobalVariable.paycheck = GlobalVariable.paycheck + count;
        count = 0;

    }
}

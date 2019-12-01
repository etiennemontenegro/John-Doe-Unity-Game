using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekHandler : MonoBehaviour
{

    public SceneHandler switchScene;
    public WorkInteraction interaction;
    float _walkTime = 5;
    float weekendTime = 120;
    float workTime = 5;
    float walkTime;

    // Start is called before the first frame update
    void Start()
    {
        walkTime = _walkTime;
    }

    // Update is called once per frame
    void Update()
    {
        
     if( GlobalVariable.walkToWork )
        {
            walkTimer();
        }

        if (GlobalVariable.backHome)
        {
            walkTimer();
        }

        if (GlobalVariable.atWork)
        {
            WorkTimer();
        }

    }

    void WeekendCheck()
    {
        if (GlobalVariable.day >= 5)
        {
            GlobalVariable.weekend = true;
        }
        else
        {
            GlobalVariable.weekend = false;
        }
    }

    void DayIsOver()
    {
        GlobalVariable.day++;

        if (GlobalVariable.day > 6)
        {
            GlobalVariable.day = 0;
        }

        WeekendCheck();

    }



    /// TIMERS ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

    void WeekendTimer()
    {
        weekendTime -= Time.deltaTime;

        if (weekendTime < 0)
        {
            GlobalVariable.weekend = false;
        }
            
    }

    void WorkTimer()
    {
        workTime -= Time.deltaTime;
        
        if (workTime < 0)
        {
          
            GlobalVariable.atWork = false;
            GlobalVariable.morning = false;
            GlobalVariable.backHome = true;
            interaction.UpdatePaycheck();
            Debug.Log(GlobalVariable.paycheck);
            GlobalVariable.hasArrived = false;
            walkTime = _walkTime;

            GameObject.Find("PrefabGameLogic").GetComponent<Animator>().SetBool("PlayFade", true);
            StartCoroutine(FadeCoroutine());   
        }
    }

    void walkTimer()
    {
        
        walkTime -= Time.deltaTime;

        if (walkTime < 0)
        {
            GlobalVariable.hasArrived = true;
        }
    }

    IEnumerator FadeCoroutine()
    {
        yield return new WaitForSeconds(1);
        switchScene.scene2To1();
    }
}



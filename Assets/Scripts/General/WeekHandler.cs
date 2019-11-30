using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekendCheker : MonoBehaviour
{

    float weekendTime = 120;
    float workTime = 90;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
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
    }

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
            GlobalVariable.morning = false;
        }

    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreTimer : MonoBehaviour
{
    public GameObject FinTimer;

    private bool timerRunning = true;

    void Awake()
    {
        FinTimer = GameObject.Find("PopUpYouSuck");
    }

    void onEnable()
    {
        timerRunning = true;
    }

    void Update()
    {
        if(timerRunning)
        {
            string minutes = Mathf.Floor(WeekHandler.weekendTime / 60).ToString("0");
            string seconds = Mathf.Floor(WeekHandler.weekendTime % 60).ToString("00");

            string time = string.Format("{0}:{1}", minutes, seconds);

            this.gameObject.GetComponent<Text>().text = time;

            if (time == "0:00")
            {
                timerRunning = false;
                time = "0:00";
                this.gameObject.GetComponent<Text>().text = time;
                FinTimer.SetActive(true);
            }
        }
    }
}

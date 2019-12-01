using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekHandler : MonoBehaviour
{

    public SceneHandler switchScene;
    public WorkInteraction interaction;
    public MoneyManagment money;
    public static float _walkTime = 5;
    public static float _weekendTime = 120;
    public static float _workTime = 5;


   public static float  walkTime;
   public static float weekendTime;
   public static float workTime;


    // Start is called before the first frame update
    void Start()
    {
        interaction = GameObject.Find("PrefabGameLogic").GetComponent<WorkInteraction>();
        money = GameObject.Find("PrefabGameLogic").GetComponent<MoneyManagment>();
        //GameObject.Find("UIFactureWeekend").SetActive(false);
        walkTime = _walkTime;
        weekendTime = _weekendTime;
        workTime = _workTime;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GlobalVariable.walkToWork);

        if (GlobalVariable.walkToWork)
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

        if( GlobalVariable.inStore)
        {
            WeekendTimer();
        }

    }

    void WeekendCheck()
    {
        if (GlobalVariable.day >= 5)
        {
            
            GlobalVariable.weekend = true;
            Debug.Log("ITS THE WEEKEND");
        }
        
    }

   public void DayIsOver()
    {
        GlobalVariable.day++;
        Debug.Log("Day :" + GlobalVariable.day);
        Debug.Log("morning :" + GlobalVariable.morning);
        if (GlobalVariable.day == 5 )
        {
            Debug.Log("inside if statement");
            money.RandomDeduction((float)GlobalVariable.paycheck);


            //ENVOYER LES DONNÉES A CATHRINE
            //afficher son UI
            if (GlobalVariable.morning)
            {
                GameObject.Find("UIFactureWeekend").SetActive(true);
            }
            GlobalVariable.wallet = GlobalVariable.wallet + GlobalVariable.paycheck - MoneyManagment.total;
            GlobalVariable.paycheck = 0;

        }

        if (GlobalVariable.day > 5)
        {
            GlobalVariable.day = 0;
            GlobalVariable.weekend = false;
            weekendTime = _weekendTime;
            Debug.Log("Reset weekend timer" + weekendTime);
        }
        Debug.Log("Day :" + GlobalVariable.day);
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
                Debug.Log("Paycheck" + GlobalVariable.paycheck);
                GlobalVariable.hasArrived = false;
                

                GameObject.Find("PrefabGameLogic").GetComponent<Animator>().SetBool("PlayFade", true);
                StartCoroutine(FadeCoroutine());
                //workTime = _workTime;
        }
        }

        void walkTimer()
        {
            
            walkTime -= Time.deltaTime;
            //Debug.Log(walkTime);
        
            if (walkTime < 0)
            {
                GlobalVariable.hasArrived = true;
               // walkTime = _walkTime;

            }
        }

        IEnumerator FadeCoroutine()
        {
            yield return new WaitForSeconds(1);
            switchScene.scene2To1();
        }
    }




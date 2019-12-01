using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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

    //GameObject UIfactureParent;
    private GameObject UIfacture;
    // Start is called before the first frame update
    void Start()
    {

        UIfacture = GameObject.Find("BackgroundBlack");
       // UIfacture.transform.position = new Vector3(0, -1000, 0);
        //UIfacture = UIfactureParent.transform.Find("UIFactureWeekend").gameObject;

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
            Debug.Log("Weekend: " + GlobalVariable.weekend + "|| Morning : " + GlobalVariable.morning);
        }
        
    }

   public void DayIsOver()
    {
        GlobalVariable.day++;
        GlobalVariable.morning = true;

        Debug.Log("Day :" + GlobalVariable.day);
        Debug.Log("morning :" + GlobalVariable.morning);

        if (GlobalVariable.day == 5 && GlobalVariable.morning)
        {

            Debug.Log("inside if statement");
            money.RandomDeduction((float)GlobalVariable.paycheck);
            UIfacture = GameObject.Find("BackgroundBlack");
            //UIfacture.transform.position = new Vector3(960*0.5f+28.5f, 540*0.5f+16, 0);
            UIfacture.transform.position = new Vector3(960, 540, 0);

            //ENVOYER LES DONNÉES A CATHRINE
            //afficher son UI

            GlobalVariable.wallet = GlobalVariable.wallet + GlobalVariable.paycheck - MoneyManagment.total;
            Debug.Log("MY WALLET : " + GlobalVariable.wallet);
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




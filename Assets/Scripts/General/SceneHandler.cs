using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{

    public WeekHandler week;    

    void Start()
    {
        
    }

    // Update is called once per frame
    public static void Update()
    {

    }

    public void scene0To1() // HOUSE TO TRAVEL
    {
       
        GlobalVariable.sceneIndex = 1;           
        SwitchScene(GlobalVariable.sceneIndex );
        GlobalVariable.walkToWork = true;
        Debug.Log("Switching from House to Walk");
    
    }

   public void scene1To2() //TRAVEL TO WORK
    {            
        GlobalVariable.sceneIndex = 2;
        SwitchScene(GlobalVariable.sceneIndex);
        GlobalVariable.walkToWork = false;
        GlobalVariable.atWork = true;
        WeekHandler.walkTime = WeekHandler._walkTime;
        Debug.Log("Reset walk timer : " + WeekHandler.walkTime);
        Debug.Log("Switching from  Walk to work");
    }

   public void scene2To1() //WORK TO TRAVEL
    {
       
        GlobalVariable.sceneIndex = 1;
        SwitchScene(GlobalVariable.sceneIndex);
        WeekHandler.workTime = WeekHandler._workTime;
        Debug.Log("Reset work timer : " + WeekHandler.workTime);
        Debug.Log("Switching from work to Walk");

    }

   public void scene1To0() //TRAVEL TO HOUSE
    {
       
        GlobalVariable.sceneIndex = 0;
        SwitchScene(GlobalVariable.sceneIndex);
        GlobalVariable.hasArrived = false;
        GlobalVariable.backHome = false;
        WeekHandler.walkTime = WeekHandler._walkTime;
        Debug.Log("Reset walk timer : " + WeekHandler.walkTime);
        Debug.Log("Switching from  Walk to House");


    }

    void SwitchScene( int load )
    {      
        SceneManager.LoadScene(load);   
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class SceneHandler : MonoBehaviour
{


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
    
    }

   public void scene1To2() //TRAVEL TO WORK
    {
        
       
            GlobalVariable.sceneIndex = 2;
            SwitchScene(GlobalVariable.sceneIndex);
        GlobalVariable.walkToWork = false;
        
    }

   public void scene2To1() //WORK TO TRAVEL
    {
       
            GlobalVariable.sceneIndex = 1;
            SwitchScene(GlobalVariable.sceneIndex);
        
    }

   public void scene1To0() //TRAVEL TO HOUSE
    {
       
            GlobalVariable.sceneIndex = 0;
            SwitchScene(GlobalVariable.sceneIndex);
        
    }

    void SwitchScene( int load )
    {
      
        SceneManager.LoadScene(load);
        

    }
}

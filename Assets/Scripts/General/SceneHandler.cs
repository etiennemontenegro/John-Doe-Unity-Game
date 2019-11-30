using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class SceneHandler : MonoBehaviour
{


    void Start()
    {
        //SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }

    // Update is called once per frame
    public static void Update()
    {

        //  if(Input.GetKeyDown(KeyCode.Space)) {GlobalVariable.goToWork = !GlobalVariable.goToWork;}

        /* if( GlobalVariable.sceneIndex == 0 && GlobalVariable.goToWork)
         {
             scene0To1();
         }

         if (GlobalVariable.sceneIndex == 1 && GlobalVariable.atWork)
         {
             scene1To2();
         }

         if (GlobalVariable.sceneIndex == 2 && GlobalVariable.workIsDone)
         {
             scene2To1();
         }

         if (GlobalVariable.sceneIndex == 1 && GlobalVariable.backHome)
         {
             scene1To0();
         }
         */
    }

    public void scene0To1() // HOUSE TO TRAVEL
    {
       //if(GlobalVariable.goToWork)
      //  {
            GlobalVariable.sceneIndex = 1;
           
            SwitchScene(GlobalVariable.sceneIndex );
      //  }
    }

   public void scene1To2() //TRAVEL TO WORK
    {
        Debug.Log("gg");
       
            GlobalVariable.sceneIndex = 2;
            SwitchScene(GlobalVariable.sceneIndex);
        
    }

    void scene2To1() //WORK TO TRAVEL
    {
        if (GlobalVariable.workIsDone)
        {
            GlobalVariable.sceneIndex = 1;
            SwitchScene(GlobalVariable.sceneIndex);
        }
    }

    void scene1To0() //TRAVEL TO HOUSE
    {
        if (GlobalVariable.backHome)
        {
            GlobalVariable.sceneIndex = 0;
            SwitchScene(GlobalVariable.sceneIndex);
        }
    }

    void SwitchScene( int load )
    {
       // SceneManager.UnloadSceneAsync(unload);  // Async beacause of weird error check if bug 
        SceneManager.LoadScene(load);
        

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class SceneHandler : MonoBehaviour
{


    void Start()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {

      //  if(Input.GetKeyDown(KeyCode.Space)) {GlobalVariable.goToWork = !GlobalVariable.goToWork;}
      
        if( GlobalVariable.sceneIndex == 0 && GlobalVariable.goToWork)
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

    }

    void scene0To1() // HOUSE TO TRAVEL
    {
        if(GlobalVariable.goToWork)
        {
            GlobalVariable.sceneIndex = 1;
           
            SwitchScene(GlobalVariable.sceneIndex, GlobalVariable.sceneIndex - 1);
        }
    }

    void scene1To2() //TRAVEL TO WORK
    {
        if( GlobalVariable.walkToWork)
        {
            GlobalVariable.sceneIndex = 2;
            SwitchScene(GlobalVariable.sceneIndex, GlobalVariable.sceneIndex - 1);
        }
    }

    void scene2To1() //WORK TO TRAVEL
    {
        if (GlobalVariable.workIsDone)
        {
            GlobalVariable.sceneIndex = 1;
            SwitchScene(GlobalVariable.sceneIndex, GlobalVariable.sceneIndex + 1);
        }
    }

    void scene1To0() //TRAVEL TO HOUSE
    {
        if (GlobalVariable.backHome)
        {
            GlobalVariable.sceneIndex = 0;
            SwitchScene(GlobalVariable.sceneIndex, GlobalVariable.sceneIndex + 1);
        }
    }

    void SwitchScene( int load , int unload)
    {
        SceneManager.UnloadSceneAsync(unload);  // Async beacause of weird error check if bug 
        SceneManager.LoadScene(load, LoadSceneMode.Additive);
        

    }
}

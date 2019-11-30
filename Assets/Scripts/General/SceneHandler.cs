using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SceneHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void scene0To1() // HOUSE TO TRAVEL
    {
        if( GlobalVariable.goToWork)
        {
            GlobalVariable.sceneIndex = 1
            
        }
    }

    void scene1To2()
    {
    }

    void scene2To1()
    {
    }

    void scene1To0()
    {
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckMenuActive : MonoBehaviour
{
    public bool menuIsActive = true;
    private Animator fadeInAnimator;
    private Text dayTextField;
    //private bool onlyOneTrigger = false;

    void Start()
    {
        fadeInAnimator = GameObject.Find("PrefabGameLogic").GetComponent<Animator>();
        dayTextField = GameObject.Find("PrefabGameLogic").GetComponent<WeekTextHandler>().dayTextField;

        if (GlobalVariable.menuWasSeen == true && GlobalVariable.onlyOneTime == true)
        {
            //GameObject.Find("CanvasUIMenu").SetActive(false);          
            foreach (Transform child in gameObject.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariable.menuWasSeen == true)
        {
            if(GlobalVariable.onlyOneTime == false)
            {
                GlobalVariable.onlyOneTime = true;   
                StartCoroutine(FadeIntro());
            }            
        }
    }   

    IEnumerator FadeIntro()
    {                 
        StartCoroutine(GameObject.Find("PrefabGameLogic").GetComponent<WeekTextHandler>().FadeTextToZeroAlpha(1f, dayTextField.GetComponent<Text>()));
        yield return new WaitForSeconds(0.75f);
        fadeInAnimator.SetFloat("RunMultiplier", 1f);                
    }
}

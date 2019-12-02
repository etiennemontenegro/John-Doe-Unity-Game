using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckMenuActive : MonoBehaviour
{
    public bool menuIsActive = true;
    private Animator fadeInAnimator;
    private Text dayTextField;

    void Start()
    {
        fadeInAnimator = GameObject.Find("PrefabGameLogic").GetComponent<Animator>();
        dayTextField = GameObject.Find("PrefabGameLogic").GetComponent<WeekTextHandler>().dayTextField;
    }

    // Update is called once per frame
    void Update()
    {
        if(menuIsActive == false)
        {
            //GlobalVariable.menuWasSeen = false;
            StartCoroutine(FadeIntro());
        }         

        /*if(GlobalVariable.menuWasSeen == false)
        {
            //GameObject.Find("CanvasUIMenu").SetActive(false);
        }*/
    }

    IEnumerator FadeIntro()
    {
        StartCoroutine(GameObject.Find("PrefabGameLogic").GetComponent<WeekTextHandler>().FadeTextToZeroAlpha(1f, dayTextField.GetComponent<Text>()));
        yield return new WaitForSeconds(0.75f);        
        fadeInAnimator.SetFloat("RunMultiplier", 1f);
    }
}

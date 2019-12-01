using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Click_Manager : MonoBehaviour
{
    
    private SceneHandler doorExitScene;



    // Start is called before the first frame update
    void Start()
    {

        doorExitScene = GameObject.Find("PrefabGameLogic").GetComponent<SceneHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        DetectElement();


    }

    public void DetectElement() {

        if (Input.GetMouseButtonDown(0)) {

            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null) {

                if (hit.transform.tag == "Door")
                {
                   


                    if (GlobalVariable.morning != true)
                    {
                        //Mike put ERROR sound here;                
                    }
                    else {
                        //Mike put DOOR sound here;               
                        GameObject.Find("PrefabGameLogic").GetComponent<Animator>().SetBool("PlayFade", true);

                        StartCoroutine(FadeCoroutine());
                        //Change scene to sam's one;
                    }
                }

                #region TV   
                


                                if (hit.transform.tag == "TV") {

                                    if (GlobalVariable._IsTooTired == true)
                                    {
                                        //Mike put error sound here;
                                        Debug.Log("I'm too tired to watch TV");

                                    }
                                    else
                                    {
                                        //Mike put dialog tv sound here;
                                       Debug.Log(" I don't want to watch tv");


                    }
                                }

               #endregion

                #region TABLE   

                if (hit.transform.tag == "Table")
                {

                        //Mike put dialog sound here;
                        Debug.Log("Its a good table");

                }

                #endregion

                #region PHONE

                if (hit.transform.tag == "Phone")
                {

                    if (GlobalVariable._IsTooTired == true)
                    {
                        //Mike put error sound here;
                        Debug.Log("I'm too tired");


                    }
                    else
                    {
                        //Mike put dialog tv sound here;
                        Debug.Log("I have no friends");


                    }
                }





                #endregion

                #region FRIDGE

                if (hit.transform.tag == "Fridge")
                {

                    if (GlobalVariable._IsTooTired == true || GlobalVariable.morning == false)
                    {
                        //Mike put error sound here;
                        Debug.Log("Im not angry");
                    }
                }

                #endregion

                #region CALENDAR

                if (hit.transform.tag == "Calendar")
                {

                    Debug.Log("I have a busy schedule");
                }

                #endregion

                if (hit.transform.tag == "Bed" && GlobalVariable.morning != true) {
                    Debug.Log("Jai hit le lit");
                    GameObject.Find("PrefabGameLogic").GetComponent<Animator>().SetBool("PlayFade", true);
                    StartCoroutine(FadeCoroutine());
                    GlobalVariable.day++;
                    GlobalVariable.morning = true;
                }
            }


        }
    }

    IEnumerator FadeCoroutine()
    {
        yield return new WaitForSeconds(1);
        doorExitScene.scene0To1();
    }
}

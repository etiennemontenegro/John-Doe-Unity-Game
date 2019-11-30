using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click_Manager : MonoBehaviour
{
  

    // Start is called before the first frame update
    void Start()
    {
        
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

                #region DOOR

                if (hit.transform.tag == "Door")
                {

                    if (GLOBAL_VARS_ANTHO._IsTooTired == true)
                    {
                        //Mike put error sound here;
                        Debug.Log("I can't quit my home");
                        
                       
                    }
                    else {
                        //Mike put DOOR sound here;
                        Debug.Log("I quit my home");
                        SceneSwitcher();
                        //Change scene to sam's one;
                    }
                }

                #endregion

                #region TV

                if (hit.transform.tag == "TV") {

                    if (GLOBAL_VARS_ANTHO._IsTooTired == true)
                    {
                        //Mike put error sound here;
                        Debug.Log("I can't watch tv");


                    }
                    else
                    {
                        //Mike put dialog tv sound here;
                        Debug.Log("I dont want to watch tv");
                        
                       
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

                    if (GLOBAL_VARS_ANTHO._IsTooTired == true)
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

            }


        }
    }

    public void SceneSwitcher() {
        SceneManager.LoadScene("OutsideAntho");
    }
}

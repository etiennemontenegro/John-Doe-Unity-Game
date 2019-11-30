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

                if (hit.transform.tag == "Door")
                {

                    if (GLOBAL_VARS_ANTHO._IsTooTired == true)
                    {
                        //Mike put error sound here;
                        Debug.Log("I can't qui my home");
                        
                       
                    }
                    else {
                        //Mike put DOOR sound here;
                        Debug.Log("I quit my home");
                        SceneSwitcher();
                        //Change scene to sam's one;
                    }
                }
            }
           
            
        }
    }

    public void SceneSwitcher() {
        SceneManager.LoadScene("OutsideAntho");
    }
}

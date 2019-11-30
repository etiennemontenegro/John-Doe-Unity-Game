using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_manager : MonoBehaviour
{

    public GameObject Door;
    private string temp;
    private string TagToCheck;

    // Update is called once per frame



    void Update()
    {
        RaycastElement();
    }

    public void RaycastElement() {

        if (Input.GetMouseButtonDown(0))
        {

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null) {

                temp = hit.collider.tag;
                TagToCheck = temp;

              

                // Verify if he can or can't quit Home;
                if (TagToCheck == Door.tag) {

                    if (GLOBAL_VARS_ANTHO._isTooTired == false)
                    {
                        Debug.Log("I quit home");
                        //put door sound here//
                    }
                    else
                    {
                        Debug.Log("I can't quit home");
                        //put door sound here//
                    }
                }







            }
        
        }

    }
}

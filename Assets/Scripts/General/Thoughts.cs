using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thoughts : MonoBehaviour
{
    private bool AlreadyDone;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("myThoughts");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator myThoughts() {

        if (AlreadyDone == false && GlobalVariable.morning == true) {
            Debug.Log("MIKE play too stress sound");
            //MIKE play too stress sound
            AlreadyDone = true;

            yield return null;
        }

        if (AlreadyDone == false && GlobalVariable.morning != true)
        {
            Debug.Log("MIKE play too tired sound");
            //MIKE play too tired sound
            AlreadyDone = true;

            yield return null;
        }


    }
}

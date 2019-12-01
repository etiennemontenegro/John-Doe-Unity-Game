using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkInteraction : MonoBehaviour
{

  public static int count = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        count++;
        //Debug.Log(count);
    }

  public void UpdatePaycheck()
    {
        
        GlobalVariable.paycheck = GlobalVariable.paycheck + count;
        count = 0;

    }
}

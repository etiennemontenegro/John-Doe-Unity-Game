using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeekTextHandler : MonoBehaviour
{
    public Text dayTextField;
    private string[] dayNames = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
    // Start is called before the first frame update
    void Start()
    {
        dayTextField.text = dayNames[GlobalVariable.day];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

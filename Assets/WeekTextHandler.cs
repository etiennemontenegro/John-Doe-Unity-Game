using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeekTextHandler : MonoBehaviour
{
    public Text dayTextField;
    private string[] dayNames = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Weekend" };
    
    void Start()
    {
        dayTextField.text = dayNames[GlobalVariable.day];
        // To Fade Out Text
        StartCoroutine(FadeTextToZeroAlpha(1f, dayTextField.GetComponent<Text>()));

        // To Fade In Text
        //StartCoroutine(FadeTextToFullAlpha(1f, dayTextField.GetComponent<Text>()));
        //print("Day index before Fade In: " + GlobalVariable.day);
    }

    void Update()
    {
        
    }

    public IEnumerator FadeTextToFullAlpha(float t, Text i)
    {
        //print("Day index before Fade In: " + GlobalVariable.day + "!!!!!!!!!!!!!!!!!!!!!!");
        dayTextField.text = dayNames[GlobalVariable.day];
        StartCoroutine("WaitForFadeOut");
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {        
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }

    public IEnumerator WaitForFadeOut()
    {        
        yield return new WaitForSeconds(1f);
        StartCoroutine(FadeTextToZeroAlpha(1f, dayTextField.GetComponent<Text>()));
    }
}
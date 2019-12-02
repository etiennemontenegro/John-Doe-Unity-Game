using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommencerJeu : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
        GameObject Menu = GameObject.Find("CanvasUIMenu");

        if(GlobalVariable.jeuEnMarche != true)
        {
            GlobalVariable.jeuEnMarche = true;
            Debug.Log("Jeu est true : " + GlobalVariable.jeuEnMarche);
            Menu.SetActive(false);
        } 
    }
}

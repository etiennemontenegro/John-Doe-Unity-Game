using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteAmazing : MonoBehaviour
{

    Text txtAmazing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtAmazing = gameObject.GetComponent<Text>();

        if (GlobalVariable.day < 3)
        {
            txtAmazing.text = "Vous colis arriveront dans" + (5 - GlobalVariable.day) + "jours!";
        }

        if (GlobalVariable.day >= 3)
        {
            txtAmazing.text = "Vous colis arriveront dans" + (5 - GlobalVariable.day) + "jour!";
        }
        if (GlobalVariable.day == 4)
        {  
            txtAmazing.text = "Vous colis sont rendus chez vous!";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
public class NoPurchase : MonoBehaviour
 
{
    public Text orderText;
    public InventoryManager Sele;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(InventoryManager.totalPrice == 0)
        {
            GetComponent<UnityEngine.UI.Text>().text = "Votre panier est vide!";
        }
      
    }
}

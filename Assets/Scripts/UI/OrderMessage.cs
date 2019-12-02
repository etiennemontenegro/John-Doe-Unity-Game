using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderMessage : MonoBehaviour
{
    public void OnClick()
    {
        InventoryManager.closeShits = true;
        this.gameObject.SetActive(false);
        GlobalVariable.inStore = false;
        GlobalVariable.morning = false;
    }
}

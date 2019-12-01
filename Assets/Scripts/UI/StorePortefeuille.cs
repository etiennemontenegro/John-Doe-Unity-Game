using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorePortefeuille : MonoBehaviour
{
    void OnEnable()
    {
        this.gameObject.GetComponent<Text>().text = GlobalVariable.wallet.ToString();
    }
}

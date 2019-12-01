using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManagment: MonoBehaviour
{

    public int montant1;
    public int montant2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomDeduction( float paycheck)
    {
        montant1 = (int)Random.Range(0.01f, 0.25f);
        montant2 = (int)Random.Range(0.01f, 0.25f);

        montant1 = (montant1 * 0.01) * paycheck;
        montant2 = (montant2 * 0.01) * paycheck;


    }
}

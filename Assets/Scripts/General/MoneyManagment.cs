using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManagment : MonoBehaviour
{

    public float montant1;
    public float montant2;
    public int total;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RandomDeduction(float paycheck)
    {
        montant1 = (int)(Random.Range(0.01f, 0.25f) * paycheck);
        montant2 = (int)(Random.Range(0.01f, 0.25f) * paycheck);

        total =(int)( paycheck - montant1 - montant2);

    }


}

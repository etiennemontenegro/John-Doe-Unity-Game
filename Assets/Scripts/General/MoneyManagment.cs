using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManagment : MonoBehaviour
{

    public static float montant1;
    public static float montant2;
    public static int montant3 = 5;
    public static int total;


    public void RandomDeduction(float paycheck)
    {
        montant1 = (int)(Random.Range(0.01f, 0.25f) * paycheck);
        montant2 = (int)(Random.Range(0.01f, 0.25f) * paycheck);

        total =(int)( paycheck - montant1 - montant2 - montant3);

    }


}

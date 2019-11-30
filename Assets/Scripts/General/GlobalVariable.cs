using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariable : MonoBehaviour
{




    //GENERAL//////////////////////////////////////////////////////

    public static int sceneIndex = 0; // 0= house 1=travel 2= work 
    
    public static int day = 0;
    public static bool morning = true;
    public static bool weekend = false;
    public static bool menu = true;
    public static bool goToWork = false;
    public static int wallet = 0; //argent dans ton compte

    public static bool startGame = false; //jouer commence a jouer ( sort du menu)

    //HOUSE/////////////////////////////////////////////////////////



    //WORK/////////////////////////////////////////////////////////
    public static bool atWork = false;
    public static bool workIsDone = false;
    public static int paycheck = 0; //salaire verser a chaque semaine

    //TRAVELLING////////////////////////////////////////////////

       public static bool walkToWork = false;
       public static bool backHome = false;

    //STORE////////////////////////////////////////////////////

    public static bool inStore = false; 



    // Start is called before the first frame update
    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        
    }
}

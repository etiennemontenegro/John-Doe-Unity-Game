using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariable : MonoBehaviour
{

    //GENERAL//////////////////////////////////////////////////////

    public static int sceneIndex = 0; // 0= house 1=travel 2= work 
    
    public static int day = 4;
    public static bool morning = true;
    public static bool weekend = false;
    public static bool menu = true;
    public static bool goToWork = false;
    public static int wallet = 10000; //argent dans ton compte

    public static bool startGame = false; //jouer commence a jouer ( sort du menu)
    public static bool menuWasSeen = false; //si le menu a été vu
    public static bool onlyOneTime = false;


    public static bool hasStarted = false;

    

    //HOUSE/////////////////////////////////////////////////////////

    public static bool _IsTooTired = false;

    //WORK/////////////////////////////////////////////////////////
    public static bool hasArrived = false;
    public static bool atWork = false;
    public static bool workIsDone = false;
    public static int paycheck ; //salaire verser a chaque semaine

    //TRAVELLING////////////////////////////////////////////////

    public static bool walkToWork = false;
    public static bool backHome = false;

    //STORE////////////////////////////////////////////////////

    public static bool inStore = false;
    public static bool setupDone = false;
    public static StoreItems[] storeItems = new StoreItems[30];

    // Start is called before the first frame update
    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantManager : MonoBehaviour
{

    public static PersistantManager Instance { get; private set; }

    // GameObject lvlChanger = GameObject.Find

    // Start is called before the first frame update

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


}

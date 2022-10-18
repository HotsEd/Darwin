using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {

        GameObject[] gameControllers = GameObject.FindGameObjectsWithTag("UIController");

        if (gameControllers.Length > 1)
        {
            Destroy(gameControllers[1]);
        }

        DontDestroyOnLoad(this.gameObject);
        

    }

}

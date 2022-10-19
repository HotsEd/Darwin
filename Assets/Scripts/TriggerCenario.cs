using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCenario : MonoBehaviour
{

    private GameController controlador;

    void Start()
    {
        controlador = GameObject.Find("GameController").GetComponent<GameController>();
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){

        if(col.tag == "Player"){
       
        }
        //Debug.Log(col.tag);
        if (col.tag == "Disparo")
        {
            Destroy(col.gameObject);
            //Debug.Log("morreu");
        }
    }
}

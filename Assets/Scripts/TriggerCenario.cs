using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCenario : MonoBehaviour
{
    
    private GameController controlador;
    public GameObject explosion;

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

        if (col.tag == "Disparo"){
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(col.gameObject);
            //Debug.Log("morreu");
        }
    }
}

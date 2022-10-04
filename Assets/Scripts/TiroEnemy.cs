using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroEnemy : MonoBehaviour
{
    private GameController controlador;

    // Start is called before the first frame update
    void Start()
    {
        controlador = GameObject.Find("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){

        if(col.tag == "Player"){
            controlador.ReiniciarLevel();
        }

    }
}

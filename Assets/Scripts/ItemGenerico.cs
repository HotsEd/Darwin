using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerico : MonoBehaviour
{
    private GameController controller;
    public bool Vida = false, Especial = false;


    private void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(Vida == true && controller != null)
            {
                controller.GanharVida();
            }

            if (Especial == true && controller != null)
            {
                controller.GanharEspecial();
            }

            Destroy(gameObject);
        }
    }
}

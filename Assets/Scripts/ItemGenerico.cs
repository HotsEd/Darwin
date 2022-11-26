using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerico : MonoBehaviour
{
    private GameController controller;
    public bool Vida = false, Especial = false;
    private AudioSource sound;


    private void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            sound.Play();

            if(Vida == true && controller != null)
            {           
                controller.GanharVida();
            }

            if (Especial == true && controller != null)
            {             
                controller.GanharEspecial();
            }
           
            Destroy(gameObject, 0.1f);
        }
    }
}

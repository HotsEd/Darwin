using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string nomeCena;
    private GameController controller;

    void OnTriggerEnter(Collider other)
    {        
        if (other.CompareTag("Player"))
        {
            
            CarregaCena(nomeCena);            
        }
    }
    public void CarregaCena(string nomeCena)
    {
        Debug.Log("Nome Da Cena = "+nomeCena);
        // if(nomeCena == "Boss01")
        // {
        //     controller.AumentarVidaBoss(10);
        // } else if(nomeCena == "Boss02") {
        //     controller.AumentarVidaBoss(20);
        // } else if(nomeCena == "Boss03") {
        //     controller.AumentarVidaBoss(50);
        // }
        SceneManager.LoadScene(nomeCena);
    }
}

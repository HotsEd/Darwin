using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string nomeCena;

    void OnTriggerEnter(Collider other)
    {        
        if (other.CompareTag("Player"))
        {
            
            CarregaCena(nomeCena);            
        }
    }
    public void CarregaCena(string nomeCena)

    {
        Debug.Log("carregou");
        SceneManager.LoadScene(nomeCena);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "peixim")
        {
            CarregaCena("Boss01");
        }
    }
    public void CarregaCena(string nomeCena)

    {
        Debug.Log("carregou");
        SceneManager.LoadScene(nomeCena);
    }
}

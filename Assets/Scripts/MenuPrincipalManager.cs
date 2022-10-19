using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;

    public void Awake()
    {

        GameObject[] controller = GameObject.FindGameObjectsWithTag("GameController");

        if(controller.Length >= 1)
        {
            foreach(GameObject item in controller)
            {
                Destroy(item);
            }
        }

        GameObject[] ui_controller = GameObject.FindGameObjectsWithTag("UIController");

        if (ui_controller.Length >= 1)
        {
            foreach (GameObject item in ui_controller)
            {
                Destroy(item);
            }
        }
    }


    public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void SairJogo()
    {
        Application.Quit();
    }
}

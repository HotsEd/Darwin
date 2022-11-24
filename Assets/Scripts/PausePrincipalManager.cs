using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePrincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelAviso;
    public KeyCode skip;

    public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
        if(Input.GetKeyDown(skip)){
            SceneManager.LoadScene(nomeDoLevelDeJogo);
        }
    }

    public void Update(){
        if(Input.GetKeyDown(skip)){
            SceneManager.LoadScene(nomeDoLevelDeJogo);
        }
    }

    public void SairJogo()
    {
        Application.Quit();
    }
    
    public void Configuracoes()
    {
        SceneManager.LoadScene("Configuracoes");
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void AbrirAviso()
    {
        painelAviso.SetActive(true);
    }
    
    public void FecharAviso()
    {
        painelAviso.SetActive(false);
    }
}

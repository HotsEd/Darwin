using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public GameObject vidaContent, especialContent;
    public GameObject vidaSprite, especialSprite;
    private static GameController instance;
    private GameObject CameraPrincipal;

    public int Vida = 3, Especial = 1;

    [SerializeField] private string nomeDoLevelDeJogo;

    public float VelCamera = 1;
    public float LimiteCenarios;   
   
    void Awake()
    {
        
        GameObject[] gameControllers = GameObject.FindGameObjectsWithTag("GameController");

        if (gameControllers.Length > 1)
        {
            Destroy(gameControllers[1]);
        }

        DontDestroyOnLoad(this.gameObject);

        instance = this;
        
    }

    public static GameController Instance()
    {
        return instance;
    }

    void Start()
    {
        CameraPrincipal = GameObject.Find("Main Camera");

        AtualizarHUD();
    }

    public void PerderVidas()
    {
        Vida--;
        //if(vidaContent.transform.childCount > 0)
            //Destroy(vidaContent.transform.GetChild(vidaContent.transform.childCount - 1).gameObject);

        AtualizarHUD();

        if (Vida <= 0)
        {
            GameOver();
        }
        else
        {
            ReiniciarLevel();
        }
    }
    public void setEspecial()
    {
        
        Especial--;

        AtualizarHUD();
        //if (especialContent.transform.childCount > 0)
            //Destroy(especialContent.transform.GetChild(especialContent.transform.childCount - 1).gameObject);
    }

    public void GameOver()
    {
        Destroy(instance);
        SceneManager.LoadScene(4);
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraPrincipal == null)
        {
            CameraPrincipal = GameObject.Find("Main Camera");
        }
        if (CameraPrincipal.transform.position.x <= LimiteCenarios)
            CameraPrincipal.transform.Translate(Vector3.right * VelCamera * Time.deltaTime);
    }

    public void ReiniciarLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void AtualizarHUD()
    {
        foreach (Transform child in vidaContent.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Transform child in especialContent.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        for (int i = 0; i < Vida; i++)
        {
            Instantiate(vidaSprite, vidaContent.transform.position, Quaternion.identity, vidaContent.transform);
        }

        for (int i = 0; i < Especial; i++)
        {
            Instantiate(especialSprite, especialContent.transform.position, Quaternion.identity, especialContent.transform);
        }

    }    

}

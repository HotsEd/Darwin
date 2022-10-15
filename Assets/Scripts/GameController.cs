using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    private static GameController instance;
    public GameObject CameraPrincipal;

    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private List<GameObject> vidasImages;
    private  int vidas ;
    public float VelCamera = 1;
    public float LimiteCenarios;   
   
    void Awake()
    {
        
        GameObject[] gameControllers = GameObject.FindGameObjectsWithTag("GameController");

        if (gameControllers.Length > 1)
        {
            Destroy(gameControllers[0]);
        }
        DontDestroyOnLoad(gameObject);
        instance = this;
        
    }

    public static GameController Instance()
    {
        return instance;
    }

    void Start()
    {
        if(vidas== 2)
        {
            vidasImages[0].SetActive(false);
            
        }
        if(vidas== 1)
        {
            vidasImages[1].SetActive(false);
            
        }
        if(vidas== 0)
        {
            vidasImages[2].SetActive(false);
        
            
        }
        
    }

    public void PerderVidas()
    {
        vidas--;
         Debug.Log(vidas);
        if(vidas== 2)
        {
          //  Debug.log("");
            vidasImages[0].SetActive(false);

            Destroy(vidasImages[0]);

            SceneManager.LoadScene("jogo");
        }
        if(vidas== 1)
        {
            vidasImages[1].SetActive(false);
            SceneManager.LoadScene("jogo");
        }
        if(vidas== 0)
        {
            vidasImages[2].SetActive(false);
            SceneManager.LoadScene("jogo");

        }
        
        
    }
    

    public void GameOver()
    {
        if(vidasImages == null)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(CameraPrincipal.transform.position.x <= LimiteCenarios)
            CameraPrincipal.transform.Translate(Vector3.right * VelCamera * Time.deltaTime);
    }

    public void ReiniciarLevel()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

}

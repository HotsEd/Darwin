using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public string ProxLevel;
    public GameObject vidaContent, especialContent;
    public GameObject vidaSprite, especialSprite;
    private static GameController instance;
    private GameObject CameraPrincipal;
    public bool podeMorrer = true;
    private bool isPaused;
    public GameObject pauseMenuUI;

    public int Vida = 3, Especial = 1, VidaBoss = 10;

    [SerializeField] private string nomeDoLevelDeJogo;

    public float VelCamera = 1;
    public float LimiteCenarios;   
   
    void Awake()
    {

        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }    

        var godBool = (PlayerPrefs.GetInt("GodMod") != 0);
        podeMorrer = !godBool;
        
        DontDestroyOnLoad(this.gameObject);
        
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

    public void GanharVida()
    {
        Vida++;
        AtualizarHUD();
    }

    public void GanharEspecial()
    {
        Especial++;
        AtualizarHUD();
    }

    public void AumentarVidaBoss(int value)
    {
        VidaBoss = value;
    }

    public void MinusVidaBoss()
    {
        VidaBoss--;
    }

    public void PerderVidas()
    {
        if (podeMorrer == true)
        {
            podeMorrer = false;
            Vida--;

            AtualizarHUD();

            StartCoroutine(ligaMorte());

            if (Vida <= 0)
            {
                StartCoroutine(gameOverRoutine());
            }
            else
            {
                StartCoroutine(esperarMorrer());
            }

        }
    }
    void PauseGame ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        isPaused=true;
    }
    void ResumeGame ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        isPaused=false;
    }
    private IEnumerator ligaMorte()
    {
        yield return new WaitForSeconds(1);
        podeMorrer = true;
    }

    private IEnumerator gameOverRoutine()
    {
        yield return new WaitForSeconds(1);
        GameOver();
    }
    
    private IEnumerator esperarMorrer()
    {
        yield return new WaitForSeconds(1);
        podeMorrer = true;
        ReiniciarLevel();
    }

    public void setEspecial()
    {
        
        Especial--;

        AtualizarHUD();

    }

    public void GameOver()
    {
        Destroy(instance);
        SceneManager.LoadScene(ProxLevel);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                SceneManager.LoadScene("Cinematic01");
            }
        }
        
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            if (Input.GetKeyDown(KeyCode.F2))
            {
                SceneManager.LoadScene("Cinematic02");
            }
        }
        
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            if (Input.GetKeyDown(KeyCode.F3))
            {
                SceneManager.LoadScene("Cinematic03");
            }
        }
        
        if  (Input.GetKeyDown("escape"))
        {
            if(isPaused==false)
            {PauseGame();}
            else{ResumeGame();}
        }
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

    public bool getPodeMorrer()
    {
        return podeMorrer;
    }    

    public void changePodeMorrer(bool mode)
    {
        PlayerPrefs.SetInt("GodMod", (mode ? 1 : 0));
        podeMorrer = mode;
    }
}
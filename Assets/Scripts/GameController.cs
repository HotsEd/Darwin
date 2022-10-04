using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    
    public GameObject CameraPrincipal;

    [SerializeField] private string nomeDoLevelDeJogo;
    public float VelCamera = 1;
    public float LimiteCenarios;   
    //teste

    // Start is called before the first frame update
    void Start()
    {
        
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

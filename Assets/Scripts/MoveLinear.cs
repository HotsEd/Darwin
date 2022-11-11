using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLinear : MonoBehaviour
{
    public float speed = 3.0f;
    public Vector3 dir;

    private GameController controlador;
    private GameObject boss;
    private Renderer objeto;

    void Start()
    {
        controlador = GameObject.Find("GameController").GetComponent<GameController>();
        objeto = GameObject.FindWithTag("Boss").GetComponent<Renderer>();
        boss = GameObject.FindWithTag("BossObject");
    }

    void Update()
    {
    transform.position += dir * speed * Time.deltaTime;        
    }
    
    void OnTriggerEnter(Collider col){

        if(col.tag == "Enemy")
        {

            Destroy(col.gameObject);

        }

        if (col.tag == "Wall")
        {
            Destroy(this.gameObject);

        }
        
        if(col.tag == "Boss"){
            controlador.MinusVidaBoss();
            StartCoroutine(ExampleCoroutine(objeto));
            if(controlador.VidaBoss == 0){
                Destroy(boss);
            }
        }

    }

    IEnumerator ExampleCoroutine(Renderer gameObjects)
    {
        gameObjects.material.color = Color.red;
        yield return new WaitForSeconds (1);
        Debug.Log("White");
        gameObjects.material.color = Color.white;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroEspecial : MonoBehaviour
{
    public float speed = 3.0f;
    public Vector3 dir;

    private GameController controlador;
    private GameObject boss;

    void Start()
    {
        controlador = GameObject.Find("GameController").GetComponent<GameController>();
    }

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Enemy")
        {            
            Destroy(col.gameObject);
            

        }
        if(col.tag == "Boss"){
            boss = GameObject.FindWithTag("BossObject");
            controlador.MinusVidaBoss();
            controlador.MinusVidaBoss();
            if(controlador.VidaBoss == 0){
                Destroy(boss);
            }
        }

    }
}

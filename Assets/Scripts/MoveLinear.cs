using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLinear : MonoBehaviour
{
    public float speed = 3.0f;
    public Vector3 dir;

    private GameController controlador;
    private GameObject boss;
    public GameObject explosion;

    void Start()
    {
        controlador = GameObject.Find("GameController").GetComponent<GameController>();
    }

    void Update()
    {
    transform.position += dir * speed * Time.deltaTime;        
    }
    
    void OnTriggerEnter(Collider col){

        if(col.tag == "Enemy")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(col.gameObject);

        }

        if (col.tag == "Wall")
        {
            Destroy(this.gameObject);

        }
        
        if(col.tag == "Boss"){
            boss = GameObject.FindWithTag("BossObject");
            controlador.MinusVidaBoss();
            if(controlador.VidaBoss == 0){
                Instantiate(explosion, (transform.position + new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f), 0.0f)), transform.rotation);
                Instantiate(explosion, (transform.position + new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f), 0.0f)), transform.rotation);
                Instantiate(explosion, (transform.position + new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f), 0.0f)), transform.rotation);
                Instantiate(explosion, (transform.position + new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f), 0.0f)), transform.rotation);
                Instantiate(explosion, (transform.position + new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f), 0.0f)), transform.rotation);
                Instantiate(explosion, (transform.position + new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f), 0.0f)), transform.rotation);
                Instantiate(explosion, (transform.position + new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f), 0.0f)), transform.rotation);
                Instantiate(explosion, (transform.position + new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f), 0.0f)), transform.rotation);
                Instantiate(explosion, (transform.position + new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f), 0.0f)), transform.rotation);
                Instantiate(explosion, (transform.position + new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f), 0.0f)), transform.rotation);
                Destroy(boss);
            }
        }

    }

}

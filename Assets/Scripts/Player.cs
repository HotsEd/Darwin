using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{   
    public float Speed;
    public KeyCode keyTiro, keyEspecial;
    public GameObject objTiro, objEspecial;

    private GameController controller;

    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
    }
    void Update()
    {
        Move();
        Limits();
        Shot();

    }

    void Move()
    {
    Vector3 lateralMovement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += lateralMovement * Time.deltaTime * Speed;
        Vector3 verticalMovement = new Vector3(0f, Input.GetAxis("Vertical"), 0f);
        transform.position += verticalMovement * Time.deltaTime * Speed;
    }


    void Shot()
    {
        
        if (Input.GetKeyDown(keyTiro))
        {
            GameObject clone = Instantiate(objTiro, transform.GetChild(0).transform.position, transform.rotation);
            Destroy(clone, 0.3f);
        }

        
        if(controller.Especial > 0) { 
            if (Input.GetKeyDown(keyEspecial)){
                GameObject clone = Instantiate(objEspecial, new Vector3(transform.position.x+4,0,0), Quaternion.identity);
                Destroy(clone,4);
                controller.setEspecial();
            }
        }

    }


    void Limits()
    {
        var distanceZ = (transform.position - Camera.main.transform.position).z;

        var leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distanceZ)).x+1.2f;
        var rigthBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distanceZ)).x;
        var topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distanceZ)).y;
        var bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, distanceZ)).y;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftBorder, rigthBorder), Mathf.Clamp(transform.position.y, topBorder, bottomBorder), transform.position.z);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            controller.PerderVidas();
            
            Destroy(other.gameObject);
        }
    }
}

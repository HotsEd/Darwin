using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour
{   
    public float Speed;

    void Start()
    {
        
    }
    void Update()
    {
        Move();
        Limits();


    }

    void Move()
    {
    Vector3 lateralMovement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += lateralMovement * Time.deltaTime * Speed;
        Vector3 verticalMovement = new Vector3(0f, Input.GetAxis("Vertical"), 0f);
        transform.position += verticalMovement * Time.deltaTime * Speed;
    }

    void Limits()
    {
        var distanceZ = (transform.position - Camera.main.transform.position).z;

        var leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distanceZ)).x;
        var rigthBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distanceZ)).x;
        var topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distanceZ)).y;
        var bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, distanceZ)).y;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftBorder, rigthBorder), Mathf.Clamp(transform.position.y, topBorder, bottomBorder), transform.position.z);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            GameController.Instance().PerderVidas();
            
            Destroy(other.gameObject);
        }
    }
}

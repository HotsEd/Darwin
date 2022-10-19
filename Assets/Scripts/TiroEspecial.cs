using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroEspecial : MonoBehaviour
{
    public float speed = 3.0f;
    public Vector3 dir;

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

    }
}

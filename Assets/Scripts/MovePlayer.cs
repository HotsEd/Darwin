using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
   public float speed;
    public GameObject Target;
    
    void Update()
    { 
        Vector3 dir = Target.transform.position - transform.position;
        float t = Time.deltaTime;
        if (dir.magnitude > 2.0f){
            transform.position = transform.position + speed * dir.normalized * t;
        }

    }
}

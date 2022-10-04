using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaEnemy : MonoBehaviour
{

    public GameObject tiro;
    public float contancia;

    public float velocidadeTiro = 10;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(disparar());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator disparar()
    {
        yield return new WaitForSeconds(Random.Range(.2f,contancia));

        GameObject clone = Instantiate(tiro, transform.GetChild(0).position, transform.GetChild(0).rotation);
        
        clone.transform.GetComponent<Rigidbody>().AddForce(clone.transform.forward * velocidadeTiro, ForceMode.Impulse);
        StartCoroutine(disparar());
        Destroy(clone,3f);
    }
}

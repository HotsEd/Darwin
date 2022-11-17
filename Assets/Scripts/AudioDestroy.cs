using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDestroy : MonoBehaviour
{
    private GameObject[] music;
    // Start is called before the first frame update
    void Start()
    {
        music = GameObject.FindGameObjectsWithTag ("Audio");
        if (music.Length > 1 ) {
            Destroy (music[0]);
        }
    }

    void Awake ()
    {
        DontDestroyOnLoad (transform.gameObject);
    }
}

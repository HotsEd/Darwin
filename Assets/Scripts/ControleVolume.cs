using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleVolume : MonoBehaviour
{
    float volumeMaster;

    public Slider sliderMaster;
    // Start is called before the first frame update
    void Start()
    {
        sliderMaster.value = PlayerPrefs.GetFloat("Value");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VolumeMaster(float volume)
    {
        volumeMaster = volume;
        AudioListener.volume = volumeMaster;
        PlayerPrefs.SetFloat("Value", volumeMaster);
    }
}

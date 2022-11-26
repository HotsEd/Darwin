using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeGodMode : MonoBehaviour
{
    private GameController controller;
    public Toggle toggle;

    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
        ChangeValueToTrue();
    }


    public void ChangeValueToTrue()
    {
        toggle.isOn = !controller.getPodeMorrer();
    }

    public void GhangeGod(bool mode)
    {
        controller.changePodeMorrer(!mode);
    }
}

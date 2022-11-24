using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeGodMode : MonoBehaviour
{
    private GameController controller;
    public bool modal;

    void Update()
    {
        GhangeGod(modal);
    }

    public void GhangeGod(bool mode)
    {
  
        controller.changePodeMorrer(mode);
    }
}

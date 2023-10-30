using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageCanvas : MonoBehaviour
{
    private void Awake()
    {
        //GameVariables.canvas_BenoitPhone = GameObject.FindGameObjectWithTag("ItemCanvas");
        GameVariables.canvas_CarlaPhone = GameObject.FindGameObjectWithTag("Canvas_CarlaPhone");
        GameVariables.canvas_PapierPC = GameObject.FindGameObjectWithTag("Canvas_papier");

        GameVariables.canvas_PapierPC.SetActive(false);
        GameVariables.canvas_CarlaPhone.SetActive(false);
    }
}

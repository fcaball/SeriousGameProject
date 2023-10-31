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
        GameVariables.canvas_Wallet = GameObject.FindGameObjectWithTag("Canvas_Wallet");

        GameVariables.canvas_PapierPC.SetActive(false);
        GameVariables.canvas_CarlaPhone.SetActive(false);
        GameVariables.canvas_Wallet.SetActive(false);
        GameVariables.canvas_Notice = GameObject.FindGameObjectWithTag("Canvas_Notice");
        GameVariables.canvas_Ordonnance = GameObject.FindGameObjectWithTag("Canvas_Ordonnance");
        GameVariables.canvas_Pilulier = GameObject.FindGameObjectWithTag("Canvas_Pilulier");
        GameVariables.canvas_Medicaments = GameObject.FindGameObjectWithTag("Canvas_Medicaments");

        GameVariables.canvas_PapierPC.SetActive(false);
        GameVariables.canvas_CarlaPhone.SetActive(false);
        GameVariables.canvas_Notice.SetActive(false);
        GameVariables.canvas_Ordonnance.SetActive(false);
        GameVariables.canvas_Pilulier.SetActive(false);
        GameVariables.canvas_Medicaments.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageCanvas : MonoBehaviour
{
    private void Awake()
    {
        GameVariables.canvas_BenoitPhone = GameObject.FindGameObjectWithTag("Canvas_BenoitPhone");
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

        GameVariables.canvas_Photo = GameObject.FindGameObjectWithTag("Canvas_Puzzle");

        GameVariables.canvas_vocal = GameObject.FindGameObjectWithTag("Canvas_vocal");

        GameVariables.canvas_charade = GameObject.FindGameObjectWithTag("Canvas_charade");

        GameVariables.canvas_dessin = GameObject.FindGameObjectWithTag("Canvas_dessin");
        GameVariables.canvas_empreinte = GameObject.FindGameObjectWithTag("Canvas_empreintes");
        GameVariables.canvas_tasse = GameObject.FindGameObjectWithTag("Canvas_tasse");
        GameVariables.canvas_cafetiere = GameObject.FindGameObjectWithTag("Canvas_cafetiere");

        GameVariables.canvas_police = GameObject.FindGameObjectWithTag("Canvas_police");

        GameVariables.canvas_Indice = GameObject.FindGameObjectWithTag("Canvas_indice");

        GameVariables.canvas_Indice1 = GameObject.FindGameObjectWithTag("Canvas_indice1");

        GameVariables.canvas_Indice2 = GameObject.FindGameObjectWithTag("Canvas_indice2");

        //GameVariables.canvas_Indice_Ordonnance = GameObject.FindGameObjectWithTag("Canvas_Indice_Ordonnance");

        GameVariables.canvas_PapierPC.SetActive(false);
        GameVariables.canvas_CarlaPhone.SetActive(false);
        GameVariables.canvas_Notice.SetActive(false);
        GameVariables.canvas_Ordonnance.SetActive(false);
        GameVariables.canvas_Pilulier.SetActive(false);
        GameVariables.canvas_Medicaments.SetActive(false);
        GameVariables.canvas_Photo.SetActive(false);
        GameVariables.canvas_BenoitPhone.SetActive(false);
        GameVariables.canvas_vocal.SetActive(false);
        GameVariables.canvas_charade.SetActive(false);
        GameVariables.canvas_dessin.SetActive(false);
        GameVariables.canvas_empreinte.SetActive(false);
        GameVariables.canvas_tasse.SetActive(false);
        GameVariables.canvas_cafetiere.SetActive(false);
        GameVariables.canvas_police.SetActive(false);
        GameVariables.canvas_Indice.SetActive(false);
        GameVariables.canvas_Indice1.SetActive(false);
        GameVariables.canvas_Indice2.SetActive(false);
    }

    public void CloseAllCanvas()
    {
        GameVariables.canvas_PapierPC.SetActive(false);
        GameVariables.canvas_CarlaPhone.SetActive(false);
        GameVariables.canvas_Notice.SetActive(false);
        GameVariables.canvas_Ordonnance.SetActive(false);
        GameVariables.canvas_Pilulier.SetActive(false);
        GameVariables.canvas_Medicaments.SetActive(false);
        GameVariables.canvas_Photo.SetActive(false);
        GameVariables.canvas_BenoitPhone.SetActive(false);
        GameVariables.canvas_vocal.SetActive(false);
        GameVariables.canvas_charade.SetActive(false);
        GameVariables.canvas_police.SetActive(false);
        GameVariables.canvas_empreinte.SetActive(false);
        GameVariables.canvas_Indice.SetActive(false);
        GameVariables.canvas_Indice1.SetActive(false);
        GameVariables.canvas_Indice2.SetActive(false);
        GameVariables.canvas_Wallet.SetActive(false);
        //GameVariables.canvas_Indice_Ordonnance.SetActive(false);
    }
}

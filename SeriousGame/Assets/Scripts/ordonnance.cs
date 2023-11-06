using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ordonnance : MonoBehaviour
{
    public TMP_InputField text1;
    public TMP_InputField text2;
    public TMP_InputField text3;

    public static GameObject indice;

    public AudioSource click;

    private void Awake()
    {
        indice = GameObject.FindGameObjectWithTag("indice_ordonnance");
    }

    void Start()
    {
        GameVariables.succeed = GameObject.Find("Succeed_enigma").GetComponent<AudioSource>();
        GameVariables.nbTentativesOrdonnance = 0;
        indice.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckAnswer()
    {
        click.Play();
        if ((text1.text == "equilibrix" || text1.text == "Equilibrix" || text1.text == "EQUILIBRIX")
        && (text2.text == "3" || text2.text == "TROIS" || text2.text == "trois" || text2.text == "Trois")
        && (text3.text == "boissons chaudes" || text3.text == "BOISSONS CHAUDES" || text3.text == "Boissons chaudes"))
        {
            GameVariables.canvas_Indice.SetActive(false);
            GameVariables.canvas_Indice_Ordonnance.SetActive(false);
            GameVariables.succeed.Play();
        }
        else if (text1.text != "" && text2.text != "" && text3.text != "")
        {
            GameVariables.nbTentativesOrdonnance += 1;
            text1.text = "";
            text2.text = "";
            text3.text = "";
            if(GameVariables.nbTentativesOrdonnance <= 2)
                GameVariables.fail.Play();
        }


        if (GameVariables.nbTentativesOrdonnance >= 3 && !GameVariables.canvas_Indice.activeSelf)
        {
            GameVariables.pop.Play();
            GameVariables.canvas_Indice.SetActive(true);
        }
    }

    public void getIndice()
    {
        click.Play();
        if (GameVariables.canvas_Indice.activeSelf)
        {
            indice.SetActive(true);
        }
    }

}

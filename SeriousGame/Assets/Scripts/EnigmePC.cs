using SojaExiles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class EnigmePC : MonoBehaviour
{
    public GameObject player;
    public Canvas canvas;
    public Canvas signIn;
     bool onPC;
    PlayerMovement playerMovement_script;
    MouseLook mouseLook;
    public Camera cam;
    public Button enter;
    public TMP_InputField saisie;
    private string reponse = "9067";
    public GameObject indice;

    private bool indiced;
    public AudioSource click;

    private void Awake()
    {
        indice = GameObject.FindGameObjectWithTag("indice_PC");
    }

    //public static bool stepOneIsPassed = false;

    void Start()
    {
        canvas.gameObject.SetActive(false);
        signIn.gameObject.SetActive(false);
        onPC = false;
        playerMovement_script = player.GetComponent<PlayerMovement>();
        mouseLook = cam.GetComponent<MouseLook>();
        enter.onClick.AddListener(Click);
        GameVariables.nbTentativesPC = 0;
        indice.SetActive(false);
        indiced = false;
    }

    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, player.transform.position);

        
        if (distance < 2f && !onPC)
        {
            canvas.gameObject.SetActive(true);
        }
        else
        {
            canvas.gameObject.SetActive(false);
        }

        if(Input.GetKey(KeyCode.F) && distance < 2f)
        {
            onPC = true;
            Cursor.lockState = CursorLockMode.None;
            signIn.gameObject.SetActive(true);
            canvas.gameObject.SetActive(false);
            if (indiced)
                GameVariables.canvas_Indice2.SetActive(true);
            playerMovement_script.enabled = false;
            mouseLook.enabled = false;
        }

        
    }

    void Click()
    {
        click.Play();
        ReponseSaisie();
    }

    public void ClosePC()
    {
        click.Play();
        onPC = false;
        Cursor.lockState = CursorLockMode.Locked;
        signIn.gameObject.SetActive(false);
        canvas.gameObject.SetActive(true);
        CanvasWeb_script.canvas_desktop.SetActive(false);
        playerMovement_script.enabled = true;
        mouseLook.enabled = true;
        GameVariables.canvas_Indice2.SetActive(false);
    }

    public void ReponseSaisie()
    {
        string UserReponse = saisie.text;
        GetFocus();

        if (UserReponse == reponse)
        {
            saisie.text = null;
            GetFocus();
            signIn.gameObject.SetActive(false);
            GameVariables.mdp_find = true;
            GameVariables.succeed.Play();
        }
        else if(UserReponse != "")
        {
            GameVariables.nbTentativesPC += 1;
            saisie.text = null;
            GetFocus();
            if (GameVariables.nbTentativesPC <= 2)
                GameVariables.fail.Play();
        }
        if (GameVariables.nbTentativesPC >= 3 && !GameVariables.canvas_Indice2.activeSelf)
        {
            GameVariables.pop.Play();
            GameVariables.canvas_Indice2.SetActive(true);
        }

    }

    public void GetIndice()
    {
        click.Play();
        if (GameVariables.canvas_Indice2.activeSelf)
        {
            indice.SetActive(true);
            indiced = true;
        }
    }


    public void GetFocus()
    {
        saisie.Select();
        saisie.ActivateInputField();
    }
}

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
    private bool onPC;
    PlayerMovement playerMovement_script;
    public Button enter;
    public TMP_InputField saisie;
    private string reponse = "9067";

    void Start()
    {
        canvas.gameObject.SetActive(false);
        signIn.gameObject.SetActive(false);
        onPC = false;
        playerMovement_script = player.GetComponent<PlayerMovement>();
        enter.onClick.AddListener(Click);
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
            playerMovement_script.enabled = false;
        }

        if(Input.GetKey(KeyCode.Escape) && onPC)
        {
            onPC = false;
            Cursor.lockState = CursorLockMode.Locked;
            signIn.gameObject.SetActive(false);
            canvas.gameObject.SetActive(true);
            playerMovement_script.enabled = true;

        }
    }

    void Click()
    {
        ReponseSaisie();
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
        }
        else
        {
            saisie.text = null;
            GetFocus();
        }

    }


    public void GetFocus()
    {
        saisie.Select();
        saisie.ActivateInputField();
    }
}

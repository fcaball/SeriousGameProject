using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using SojaExiles;

public class BenoitEnigmeAnswer : MonoBehaviour
{
    public GameObject player;
    public TMP_InputField inputField;
   /* public Image canvaEnigme;*/
    //public Canvas canvaVocal;
    MouseLook camera_script;
    public GameObject camera;
    PlayerMovement playerMovement_script;
    public AudioSource vocal;
    public AudioSource click;

    // Start is called before the first frame update
    void Start()
    {
        /*canvaEnigme.gameObject.SetActive(true);*/
        //canvaVocal.gameObject.SetActive(false);
        playerMovement_script = player.GetComponent<PlayerMovement>();
        camera_script = camera.GetComponent<MouseLook>();
    }

    public void ClickButton(){
        click.Play();
        if(inputField.text == "79410"){
            GameVariables.succeed.Play();
            GameVariables.canvas_vocal.SetActive(true);
            GameVariables.canvas_BenoitPhone.SetActive(false);
        }
        else
        {
            GameVariables.fail.Play();
        }
    }

    public void SoundButton()
    {
        vocal.Play();
    }
}

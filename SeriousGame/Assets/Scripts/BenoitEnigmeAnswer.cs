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

    // Start is called before the first frame update
    void Start()
    {
        /*canvaEnigme.gameObject.SetActive(true);*/
        //canvaVocal.gameObject.SetActive(false);
        playerMovement_script = player.GetComponent<PlayerMovement>();
        camera_script = camera.GetComponent<MouseLook>();
    }

    public void ClickButton(){
        Debug.Log("ici");
        if(inputField.text == "7940"){
            Debug.Log("Succeed");
            GameVariables.canvas_vocal.SetActive(true);
            GameVariables.canvas_BenoitPhone.SetActive(false);
        }
    }

    public void SoundButton()
    {
        vocal.Play();
    }
}

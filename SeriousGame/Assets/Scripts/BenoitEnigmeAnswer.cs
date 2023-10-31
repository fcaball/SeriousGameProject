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
    public Image canvaEnigme;
    public Image canvaVocal;
    MouseLook camera_script;
    public GameObject camera;
    PlayerMovement playerMovement_script;

    // Start is called before the first frame update
    void Start()
    {
        canvaEnigme.gameObject.SetActive(true);
        canvaVocal.gameObject.SetActive(false);
        playerMovement_script = player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement_script.enabled = false;
        camera_script.enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ClickButton(){
        if(inputField.text == "7940"){
            Debug.Log("Succeed");
            canvaVocal.gameObject.SetActive(true);
            canvaEnigme.gameObject.SetActive(false);

        }
    }
}

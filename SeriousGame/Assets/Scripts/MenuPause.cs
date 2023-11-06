using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using SojaExiles;

public class MenuPause : MonoBehaviour
{
    PlayerMovement playerMovement_script;
    MouseLook camera_script;
    public GameObject player;
    public GameObject camera;
    public Canvas pause;
    public AudioSource click;

    private void Start()
    {
        pause.gameObject.SetActive(false);
        playerMovement_script = player.GetComponent<PlayerMovement>();
        camera_script = camera.GetComponent<MouseLook>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            pause.gameObject.SetActive(true);
            playerMovement_script.enabled = false;
            camera_script.enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void Reprendre()
    {
        click.Play();
        pause.gameObject.SetActive(false);
        playerMovement_script.enabled = true;
        camera_script.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Quitter()
    {
        click.Play();
        SceneManager.LoadScene(0);
    }
}

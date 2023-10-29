using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SojaExiles;
using System;

public class ManageInventory : MonoBehaviour
{
    public Canvas inventory;
    PlayerMovement playerMovement_script;
    MouseLook camera_script;
    public GameObject player;
    public GameObject camera;

    public Button closeButton;

    void Start()
    {
        inventory.gameObject.SetActive(false);
        playerMovement_script = player.GetComponent<PlayerMovement>();
        camera_script = camera.GetComponent<MouseLook>();
        closeButton.onClick.AddListener(CloseInventory);
    }

    private void CloseInventory()
    {
        inventory.gameObject.SetActive(false);
        playerMovement_script.enabled = true;
        camera_script.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.I))
        {
            inventory.gameObject.SetActive(true);
            playerMovement_script.enabled = false;
            camera_script.enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takePhone : MonoBehaviour
{
    public GameObject player;
    public Canvas canvas;
    PlayerMovement mvtJoueur;
    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(false);
        mvtJoueur = player.GetComponent<PlayerMovement>();
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            canvas.gameObject.SetActive(true);
            mvtJoueur.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other){
        canvas.gameObject.SetActive(false);
        mvtJoueur.enabled = true;
    }
}

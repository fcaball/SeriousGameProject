using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmePC : MonoBehaviour
{
    public GameObject player;
    public Canvas canvas;
    public Canvas signIn;
    private bool onPC;
    /*MouvementJoueur monScript;*/


    void Start()
    {
        canvas.gameObject.SetActive(false);
        signIn.gameObject.SetActive(false);
        onPC = false;
        /*monScript = player.GetComponent<MouvementJoueur>();*/    
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
            signIn.gameObject.SetActive(true);
            canvas.gameObject.SetActive(false);
            /*monScript.enabled = false;*/
        }

        if(Input.GetKey(KeyCode.Escape) && onPC)
        {
            onPC = false;
            signIn.gameObject.SetActive(false);
            canvas.gameObject.SetActive(true);
            /*monScript.enabled = true;*/

        }
    }
}

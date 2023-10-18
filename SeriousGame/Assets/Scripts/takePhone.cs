using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takePhone : MonoBehaviour
{
    public GameObject player;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            canvas.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canvas.gameObject.SetActive(false);
       
    }

    private void OnTriggerStay(Collider other){
        if(other.tag == "Player"){
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("F key was pressed.");
            }
        }
    }

}

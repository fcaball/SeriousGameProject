using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takePhone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onTriggerEnter(Collider other){
        if(other.tag == "Player"){
            Debug.Log("Collision");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ordonnance : MonoBehaviour
{
    public TMP_InputField text1;
    public TMP_InputField text2;
    public TMP_InputField text3;

    // Start is called before the first frame update
    void Start()
    {
        GameVariables.succeed = GameObject.Find("Succeed_enigma").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckAnswer(){
        if((text1.text == "equilibrix" || text1.text == "Equilibrix" || text1.text == "EQUILIBRIX") 
        && (text2.text == "3" || text2.text == "TROIS" || text2.text == "trois" || text2.text == "Trois")
        && (text3.text == "boissons chaudes" || text3.text == "BOISSONS CHAUDES" || text3.text == "Boissons chaudes")){
            GameVariables.succeed.Play();
        }
    }
}

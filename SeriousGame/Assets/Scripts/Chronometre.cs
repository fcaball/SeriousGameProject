using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Chronometre : MonoBehaviour
{

    public TMP_Text timer;
    public Canvas canva_timer;
    public static float time;
    float zero = 0;
/*    public Button relancer;
    public Button quitter;*/


    void Start()
    {
        canva_timer = timer.GetComponentInParent<Canvas>(); 
        canva_timer.gameObject.SetActive(true); 
        time = 3600f;
    }

    void Update()
    {
        
        string minutes = ((int) time / 60).ToString(); 
        string secondes = (time % 60).ToString("N0"); 

        timer.text = minutes + ":" + secondes; 

        time -= Time.deltaTime; //on decremente le timer

        if (minutes == zero.ToString() && secondes == zero.ToString())
        {
            GameVariables.gameOver = true;
        }
    }

    void ClickRestart()
    {
        SceneManager.LoadScene(2);
    }

    void ClickQuit()
    {
        SceneManager.LoadScene(0);
    }

}

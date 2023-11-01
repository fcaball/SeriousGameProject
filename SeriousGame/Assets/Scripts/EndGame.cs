using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Canvas canvas_fin;
    public Canvas cursor;

    public Image bg_carla;
    public Image bg_benoit;
    public Image bg_mamie;
    public Image bg_margot;
    public Image bg_antony;
    public Image bg_anais;
    public Image bg_poison;
    public Image bg_repasser;
    public Image bg_sac;

    public Sprite background_selected;
    public Sprite background_unselected;

    bool open;
    bool selected;

    void Start()
    {
        canvas_fin.gameObject.SetActive(false);
        /*bg_anais.gameObject.SetActive(false);
        bg_benoit.gameObject.SetActive(false);
        bg_antony.gameObject.SetActive(false);
        bg_margot.gameObject.SetActive(false);
        bg_mamie.gameObject.SetActive(false);
        bg_carla.gameObject.SetActive(false);
        bg_poison.gameObject.SetActive(false);
        bg_repasser.gameObject.SetActive(false);
        bg_sac.gameObject.SetActive(false);*/

        open = false;
        selected = false;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.P) && !GameVariables.gameOver)
        {
            open = !open;
            if(open)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
            canvas_fin.gameObject.SetActive(open);
            cursor.gameObject.SetActive(!open);
        }

        if(GameVariables.gameOver)
        {
            Cursor.lockState = CursorLockMode.None;
            canvas_fin.gameObject.SetActive(true);
            cursor.gameObject.SetActive(false);
        }
    }


    public void Selected(Image img)
    {
        selected = !selected;

        if (selected)
            img.sprite = background_selected;
        else
            img.sprite = background_unselected;
    }


    public void Validation()
    {

    }
}

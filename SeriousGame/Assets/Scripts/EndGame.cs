using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    public List<Image> images = new();

    public Sprite background_selected;
    public Sprite background_unselected;
    public Sprite background_valid;
    public Sprite background_notvalid;

    private string arme = "bg_poison";
    private string personne = "bg_mamie";

    public TMP_Text mauvaiseSaisie;

    private List<string> prenoms = new();

    bool open;
    bool selected;

    void Start()
    {
        mauvaiseSaisie.gameObject.SetActive(false);

        canvas_fin.gameObject.SetActive(false);

        images.Add(bg_sac);
        images.Add(bg_anais);
        images.Add(bg_antony);
        images.Add(bg_benoit);
        images.Add(bg_carla);
        images.Add(bg_mamie);
        images.Add(bg_margot);
        images.Add(bg_poison);
        images.Add(bg_repasser);

        prenoms.Add("bg_anais");
        prenoms.Add("bg_antony");
        prenoms.Add("bg_benoit");
        prenoms.Add("bg_carla");
        prenoms.Add("bg_mamie");
        prenoms.Add("bg_margot");


        open = false;
        selected = false;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Tab) && !GameVariables.gameOver)
        {
            Cursor.lockState = CursorLockMode.None;
            
            canvas_fin.gameObject.SetActive(true);
            cursor.gameObject.SetActive(false);
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

    private bool Compare(List<string> names, string name)
    {
        foreach(string n in names)
        {
            if (n == name)
                return true;
        }

        return false;
    }

    public void Validation()
    {
        List<Image> selected_img = new();

        foreach(Image img in images)
        {
            if(img.sprite == background_selected)
            {
                selected_img.Add(img);
            }
        }

        if(selected_img.Count != 2)
        {
            mauvaiseSaisie.gameObject.SetActive(true);
            StartCoroutine(ErrorMessage(selected_img));
        }

        bool two_persons_selected = false;

        if (Compare(prenoms, selected_img[0].gameObject.name) && Compare(prenoms, selected_img[1].gameObject.name))
        {
            Debug.Log("deux personnes");

            two_persons_selected = true;
            mauvaiseSaisie.gameObject.SetActive(true);
            StartCoroutine(ErrorMessage(selected_img));
        }

        bool answer = (selected_img[0].gameObject.name == personne && selected_img[1].gameObject.name == arme) || (selected_img[1].gameObject.name == personne && selected_img[0].gameObject.name == arme);

        if (answer)
        {
            selected_img[0].sprite = background_valid;
            selected_img[1].sprite = background_valid;
        }
        else if(!answer && selected_img.Count == 2 && !two_persons_selected)
        {
            selected_img[0].sprite = background_notvalid;
            selected_img[1].sprite = background_notvalid;
            StartCoroutine(SaisiePasValid(selected_img[0], selected_img[1]));
        }
    }

    IEnumerator SaisiePasValid(Image img1, Image img2)
    {
        yield return new WaitForSeconds(1f);
        img1.sprite = background_unselected;
        img2.sprite = background_unselected;
    }

    IEnumerator ErrorMessage(List<Image> imgs)
    {
        yield return new WaitForSeconds(2f);
        mauvaiseSaisie.gameObject.SetActive(false);
        foreach(Image i in imgs)
        {
            i.sprite = background_unselected;
        }
    }
}

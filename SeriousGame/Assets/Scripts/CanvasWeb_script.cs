using UnityEngine;
using UnityEngine.UI;


public class CanvasWeb_script : MonoBehaviour
{
    public Canvas canvas;
    [SerializeField] Button web;
    private bool switch_sceen;
    [SerializeField] Image desktop;
    [SerializeField] Image webPage;

    void Start()
    {
        canvas.gameObject.SetActive(false);
        web.onClick.AddListener(ClickOnWeb);
        switch_sceen = true;
    }

    void ClickOnWeb()
    {
        switch_sceen = !switch_sceen;
    }

    void Update()
    {
        if (GameVariables.mdp_find)
        {
            canvas.gameObject.SetActive(true);
            GameVariables.mdp_find = false;
        }

        if(switch_sceen)
        {
            desktop.gameObject.SetActive(true);
            webPage.gameObject.SetActive(false);
        }
        else
        {
            /*desktop.gameObject.SetActive(false);*/
            webPage.gameObject.SetActive(true);
        }
    }
}

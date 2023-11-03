using UnityEngine;
using UnityEngine.UI;


public class CanvasWeb_script : MonoBehaviour
{
    public static GameObject canvas_desktop;
    [SerializeField] Button web_button;
    private bool switch_sceen;
    [SerializeField] Image desktop;
    [SerializeField] Image webPage;


    void Start()
    {
        canvas_desktop = GameObject.FindGameObjectWithTag("Canvas_web");
        canvas_desktop.gameObject.SetActive(false);
        web_button.onClick.AddListener(ClickOnWeb);
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
            canvas_desktop.gameObject.SetActive(true);
            GameVariables.mdp_find = false;
        }

        if(switch_sceen)
        {
            desktop.gameObject.SetActive(true);
            webPage.gameObject.SetActive(false);
        }
        else
        {
            //desktop.gameObject.SetActive(false);
            webPage.gameObject.SetActive(true);
        }
    }
}

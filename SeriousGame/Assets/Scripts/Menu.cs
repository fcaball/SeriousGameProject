using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button play;
    public Button quit;
    public Button settings;
    public Button back;
    public AudioSource soundButton;
    public Canvas CanvasMenu;
    public Canvas CanvasSettings;


    void Start()
    {
        play.onClick.AddListener(ClickPlay);
        quit.onClick.AddListener(ClickQuit);
        settings.onClick.AddListener(ClickSettings);
        back.onClick.AddListener(ClickBack);

        CanvasSettings.gameObject.SetActive(false);

    }

    void ClickPlay()
    {
        soundButton.Play();
        SceneManager.LoadScene(1);
    }

    void ClickQuit()
    {
        soundButton.Play();
    }

    void ClickSettings()
    {
        soundButton.Play();
        CanvasMenu.gameObject.SetActive(false);
        CanvasSettings.gameObject.SetActive(true);
    }

    void ClickBack()
    {
        soundButton.Play();
        CanvasMenu.gameObject.SetActive(true);
        CanvasSettings.gameObject.SetActive(false);
    }


}

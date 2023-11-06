using UnityEngine;
using TMPro;


public class Screen_Carla_Handler : MonoBehaviour
{
    [SerializeField] private Canvas firstEcran;
    [SerializeField] private Canvas secondEcran;
    public static GameObject indice;
    bool stepOneisPassed = false;

    private void Awake()
    {
        indice = GameObject.FindGameObjectWithTag("indice_CarlaPhone");
    }


    // Start is called before the first frame update
    void Start()
    {
        GameVariables.succeed = GameObject.Find("Succeed_enigma").GetComponent<AudioSource>();
        secondEcran.gameObject.SetActive(false);
        GameVariables.nbTentativesCarlaPhone = 0;
        indice.SetActive(false);
    }

    void StartTel()
    {
        firstEcran.gameObject.SetActive(true);
    }

    public void UserInput(TMP_InputField userField)
    {
        if (userField.text == "maux 2 pass")
        {
            GameVariables.succeed.Play();
            firstEcran.gameObject.SetActive(false);
            secondEcran.gameObject.SetActive(true);

        }
        else if(userField.text != "")
        {
            GameVariables.nbTentativesCarlaPhone += 1;
            userField.text = "";
            if (GameVariables.nbTentativesCarlaPhone <= 2)
                GameVariables.fail.Play();
        }
        if (GameVariables.nbTentativesCarlaPhone >= 3 && !GameVariables.canvas_Indice1.activeSelf)
        {
            GameVariables.pop.Play();
            GameVariables.canvas_Indice1.SetActive(true);
        }
    }

    public void GetIndice()
    {
        if (GameVariables.canvas_Indice1.activeSelf)
        {
            indice.SetActive(true);
        }
    }

}

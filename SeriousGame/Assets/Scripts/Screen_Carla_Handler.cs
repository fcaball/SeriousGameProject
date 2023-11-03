using UnityEngine;
using TMPro;


public class Screen_Carla_Handler : MonoBehaviour
{
    [SerializeField] private Canvas firstEcran;
    [SerializeField] private Canvas secondEcran;
    bool stepOneisPassed = false;
    // Start is called before the first frame update
    void Start()
    {
        secondEcran.gameObject.SetActive(false);
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
        else
        {
            GameVariables.fail.Play();
        }
    }
}

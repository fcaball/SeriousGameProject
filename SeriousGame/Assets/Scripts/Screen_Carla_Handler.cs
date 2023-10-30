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

    // Update is called once per frame
    void Update()
    {

    }

    void StartTel()
    {
        firstEcran.gameObject.SetActive(true);
    }

    public void UserInput(TMP_InputField userField)
    {
        Debug.Log("ici");
        if (userField.text == "mot 2 pass")
        {
            firstEcran.gameObject.SetActive(false);
            secondEcran.gameObject.SetActive(true);

        }
    }
}

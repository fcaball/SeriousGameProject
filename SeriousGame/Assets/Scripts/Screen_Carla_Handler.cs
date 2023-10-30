using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screen_Carla_Handler : MonoBehaviour
{
    [SerializeField] private Canvas firstEcran;
    [SerializeField] private Canvas secondEcran;
    bool stepOneisPassed = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartTel()
    {
        firstEcran.gameObject.SetActive(true);
    }

    public void UserInput(InputField userField)
    {
        if (userField.text == "mot 2 pass")
        {
            firstEcran.gameObject.SetActive(false);
            secondEcran.gameObject.SetActive(true);

        }
    }
}

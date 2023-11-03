using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageSounds : MonoBehaviour
{
    void Start()
    {
        GameVariables.succeed = GameObject.Find("Succeed_enigma").GetComponent<AudioSource>();
        GameVariables.fail = GameObject.Find("Fail_enigma").GetComponent<AudioSource>();
        GameVariables.pickUp_sound = GameObject.Find("pickUpSound").GetComponent<AudioSource>();
    }
}

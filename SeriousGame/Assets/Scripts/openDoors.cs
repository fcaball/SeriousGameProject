using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoors : MonoBehaviour
{

    public Animator Closetopenandclose;
    public bool open;
    public Transform Player;

    void Start()
    {
        open = false;
    }

    void Update()
    {
        float dist = Vector3.Distance(Player.position, transform.position);

        if(open == false && Input.GetKey(KeyCode.F))
        {
            StartCoroutine(opening());
        }

        if(open && Input.GetKey(KeyCode.F))
        {
            StartCoroutine(closing());
        }
    }

    IEnumerator opening()
    {
        print("you are opening the door");
        Closetopenandclose.Play("ClosetOpening");
        open = true;
        yield return new WaitForSeconds(.5f);
    }

    IEnumerator closing()
    {
        print("you are closing the door");
        Closetopenandclose.Play("ClosetClosing");
        open = false;
        yield return new WaitForSeconds(.5f);
    }
}

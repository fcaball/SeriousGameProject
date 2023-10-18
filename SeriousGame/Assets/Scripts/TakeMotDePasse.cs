using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeMotDePasse : MonoBehaviour
{
    public Camera cam;
    private RaycastHit hit;
    void Start()
    {
        
    }

    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 20))
        {
            if (hit.transform.tag == "motDePasse" && Input.GetMouseButtonDown(0))
            {
                Debug.Log("took");
            }
        }
    }
}

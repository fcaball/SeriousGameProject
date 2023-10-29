using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageCanvas : MonoBehaviour
{
    private void Awake()
    {
        GameVariables.canvas = GameObject.FindGameObjectsWithTag("ItemCanvas");
        Debug.Log(GameVariables.canvas.Length);
        foreach (GameObject c in GameVariables.canvas)
        {
            c.SetActive(false);
        }
    }
}

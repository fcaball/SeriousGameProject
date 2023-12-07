using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Typewriter : MonoBehaviour
{
    string originalText;
    TMP_Text uiText;
    public float delay = 0.2f;

    bool finish = false;

    private void Awake()
    {
        uiText = GetComponent<TMP_Text>();
        originalText = uiText.text;
        uiText.text = null;
        StartCoroutine(LetterbyLetter());
    }

    IEnumerator LetterbyLetter()
    {
        for (int i = 0; i <= originalText.Length; i++)
        {
            uiText.text = originalText.Substring(0, i);
            yield return new WaitForSeconds(delay);
        }

        finish = true;
    }

    public void Skip()
    {
        SceneManager.LoadScene(2);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Typewriter : MonoBehaviour
{
    string originalText;
    TMP_Text uiText;
    public float delay = 0.2f;
    AudioSource typewriter;

    private void Awake()
    {
        /*typewriter = GetComponent<AudioSource>();*/
        uiText = GetComponent<TMP_Text>();
        originalText = uiText.text;
        uiText.text = null;
        StartCoroutine(LetterbyLetter());
    }

    IEnumerator LetterbyLetter()
    {
        for (int i = 0; i < originalText.Length; i++)
        {
            uiText.text = originalText.Substring(0, i);
            yield return new WaitForSeconds(delay);
        }
    }
}

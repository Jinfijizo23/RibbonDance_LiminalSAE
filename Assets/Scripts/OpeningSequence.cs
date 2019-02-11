using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpeningSequence : MonoBehaviour {

    float fadeDuration = 3.0f;
    public Text title;
    public float Timeup = 3.0f;

    void Start()
    {
        StartCoroutine(Sequence());
    }
    IEnumerator Sequence()
    {
     title.canvasRenderer.SetAlpha(0);
     title.CrossFadeAlpha(1, fadeDuration, false);
        Debug.Log("Fading in");
     yield return new WaitForSeconds(fadeDuration + Timeup);
        Debug.Log("Fading out");
     title.CrossFadeAlpha(0, fadeDuration, false);
        yield return new WaitForSeconds(fadeDuration);
        SceneManager.LoadScene(1);
    }
}

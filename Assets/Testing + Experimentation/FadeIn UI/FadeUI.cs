using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeUI : MonoBehaviour {

    float fadeDuration = 10.0f;
    public Image title;
    public Text Manual;
    public float TimeOfExperience = 300.0f;

    void Start()
    {
        StartCoroutine(Sequence());
    }
    IEnumerator Sequence()
    {
        title.CrossFadeAlpha(0, fadeDuration, false);
        //Debug.Log("Fading in");
        yield return new WaitForSeconds(fadeDuration + TimeOfExperience);
        //Debug.Log("Fading out");
        title.CrossFadeAlpha(1, fadeDuration, false);
        yield return new WaitForSeconds(fadeDuration);
    }
}

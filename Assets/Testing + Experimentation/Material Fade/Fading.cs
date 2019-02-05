using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fading : MonoBehaviour {

   Renderer R;


    void Start()
    {
        R = GetComponent<Renderer>();
        Color Alpha = R.material.color;
        Alpha.a = 0f;
        R.material.color = Alpha;
        StartCoroutine("FadeIn");
    }
    IEnumerator FadeIn()
    {
        for(float f = 0.05f; f <= 1; f += 0.05f)
        {
            Color Alpha = R.material.color;
            Alpha.a = f;
            R.material.color = Alpha;
            yield return new WaitForSeconds(0.05f);
        }
    }
}

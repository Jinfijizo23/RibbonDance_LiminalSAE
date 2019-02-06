using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fading : MonoBehaviour {

   Renderer R;
   Collider H;
   Color Alpha;
    float f = 0.05f;
    public float count = 10.0f;


    void Start()
    {
        R = GetComponent<Renderer>();
        H = GetComponent<Collider>();
        H.enabled = false;
        Alpha = R.material.color;
        Alpha.a = 0f;
        R.material.color = Alpha;
        StartCoroutine("FadeIn");
    }

    IEnumerator FadeIn()
    {
        while (f <= 1.0f)
        {
            f += 0.01f;
            Alpha = R.material.color;
            Alpha.a = f;
            R.material.color = Alpha;
            yield return new WaitForSeconds(0.05f);
        }
        H.enabled = true;
        Debug.Log("Object Complete");
        yield return new WaitForSeconds(count);
        Debug.Log("Thanos snapped his fingers");
        StartCoroutine(FadeOut());
    }
    IEnumerator FadeOut()
    {
        H.enabled = false;
        while (f>=0.0f)
        {
            f -= 0.01f;
            Alpha.a = f;
            R.material.color = Alpha;
            yield return new WaitForSeconds(0.05f);
        }     
        yield return null/*new WaitForSeconds(3.0f)*/;
        Debug.Log("He Won");
        Destroy(gameObject);
    }
}

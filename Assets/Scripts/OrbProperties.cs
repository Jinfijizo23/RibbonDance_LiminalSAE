﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbProperties : MonoBehaviour {

    public Color Tintset;
    private Renderer X;
    public ParticleSystem y;
    public ParticleSystem Z;
    private float speed = 2.5f;
    Collider H;
    Color Alpha;
    float f = 0.05f;
    float count = 60.0f;


    void Start()
    {
        X = GetComponent<Renderer>();
        H = GetComponent<Collider>();
        H.enabled = false;
        y.Pause();
        Alpha = X.material.color;
        Alpha.a = 0f;
        X.material.color = Alpha;
        StartCoroutine("FadeIn");
    }
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wisp")
        {
            X.enabled = false;
            y.Stop();
            Z.Play();
            Destroy(gameObject,1);
        }
    }
    IEnumerator FadeIn()
    {
        while (f <= 1.0f)
        {
            f += 0.01f;
            Alpha = X.material.color;
            Alpha.a = f;
            X.material.color = Alpha;
            yield return new WaitForSeconds(0.05f);
        }
        H.enabled = true;
        y.Play();
        //Debug.Log("Object Complete");
        yield return new WaitForSeconds(count);
       // Debug.Log("Thanos snapped his fingers");
        StartCoroutine(FadeOut());
    }
    IEnumerator FadeOut()
    {
        H.enabled = false;
        y.Stop();
        while (f >= 0.0f)
        {
            f -= 0.01f;
            Alpha.a = f;
            X.material.color = Alpha;
            yield return new WaitForSeconds(0.05f);
        }
        yield return null;
       // Debug.Log("He Won");
        Destroy(gameObject);
    }
}

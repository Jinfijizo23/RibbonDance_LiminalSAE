using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbProperties : MonoBehaviour {

    public Color Tintset;
    public Color Groundset;
    public float Expo;
    private Renderer X;
    public ParticleSystem y;
    public ParticleSystem Z;
    public float revive;
    public float settime = 5f;

    void Start()
    {
        X = GetComponent<Renderer>();
        revive = settime;
    }
    void Update()
    {
        revive -= Time.deltaTime;
        //Debug.Log(revive);
        if (revive <= 0)
        {
            Revive();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wisp")
        {
            X.enabled = false;
            y.Stop();
            Z.Play();
        }
    }
    void Revive()
    {
        X.enabled = true;
        y.Play();
        Z.Stop();
        revive = settime;
    }
}

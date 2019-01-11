using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Psorbproperties : MonoBehaviour {

    public Color Tintset;
    //public Color Groundset;
    //public float Expo;
    private ParticleSystem X;
    private Renderer y;
    public float revive;
    public float settime = 5f;

    void Start()
    {
        X = GetComponent<ParticleSystem>();
        y = GetComponent<Renderer>();
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
            Debug.Log("Hit");
            y.enabled = false;
            //X.Stop();
        }
    }
    void Revive()
    {
        //X.Play();
        y.enabled = true;
        Debug.Log("Return");
        revive = settime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerping : MonoBehaviour {

    public float speed = 1.0f;
    public Color Current;
    public Color NewColor;
    float Starttime;

	// Use this for initialization
	void Start ()
    {
        Starttime = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float t = (Time.time - Starttime) * speed;
        GetComponent<Renderer>().material.color = Color.Lerp(Current, NewColor, t);
        Debug.Log(GetComponent<Renderer>().material.color);
        if(GetComponent<Renderer>().material.color == NewColor)
        {
            Current = NewColor;
        }
	}
}

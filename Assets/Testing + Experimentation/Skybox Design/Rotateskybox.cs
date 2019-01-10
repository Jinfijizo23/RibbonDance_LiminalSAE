using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotateskybox : MonoBehaviour {

    public float Rotatespeed;

	void Update ()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * Rotatespeed);
	}
}

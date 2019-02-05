using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bang : MonoBehaviour {
    private float speed = 2.5f;


	void Update ()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
    }
}


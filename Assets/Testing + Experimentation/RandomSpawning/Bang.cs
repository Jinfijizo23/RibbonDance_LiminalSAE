﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bang : MonoBehaviour {

	void Update ()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
    }
}

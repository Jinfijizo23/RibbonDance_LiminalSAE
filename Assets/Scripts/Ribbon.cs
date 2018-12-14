﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ribbon : MonoBehaviour {

    public SkyMaster MasterGameobject;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Orb")
        {
            MasterGameobject.changeTint(other.GetComponent<OrbProperties>().Tintset);
            Debug.Log(other.GetComponent<OrbProperties>().Tintset);
            MasterGameobject.changeFloor(other.GetComponent<OrbProperties>().Groundset);
            Debug.Log(other.GetComponent<OrbProperties>().Groundset);
            MasterGameobject.changeExpo(other.GetComponent<OrbProperties>().Expo);
            Debug.Log(other.GetComponent<OrbProperties>().Expo);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PsRibbon : MonoBehaviour {

    public SkyMaster MasterGameobject;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Orb")
        {
            MasterGameobject.changeTint(other.GetComponent<Psorbproperties>().Tintset);
            //Debug.Log(other.GetComponent<OrbProperties>().Tintset);
            //MasterGameobject.changeFloor(other.GetComponent<Psorbproperties>().Groundset);
            ////Debug.Log(other.GetComponent<OrbProperties>().Groundset);
            //MasterGameobject.changeExpo(other.GetComponent<Psorbproperties>().Expo);
            ////Debug.Log(other.GetComponent<OrbProperties>().Expo);
        }
    }
}

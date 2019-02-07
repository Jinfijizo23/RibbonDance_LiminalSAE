using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyMaster : MonoBehaviour {

    public GameObject MasterObject;
    public GameObject Hunter;

    public void changeTint(Color ST)
    {
        if (RenderSettings.skybox.HasProperty("_Tint"))
        {
            RenderSettings.skybox.SetColor("_Tint", ST);
        }
    }
}

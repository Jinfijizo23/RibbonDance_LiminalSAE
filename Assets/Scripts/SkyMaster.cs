using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyMaster : MonoBehaviour {

    public GameObject MasterObject;
    //public GameObject Victim;
    //private Renderer R;
    //public OrbProperties Change;
    public GameObject Hunter;

    // Use this for initialization
    //void Start()
    //{
    //    R = Victim.GetComponent<Renderer>();
    //}

    public void changeTint(Color ST)
    {
        if (RenderSettings.skybox.HasProperty("_Tint"))
        {
            RenderSettings.skybox.SetColor("_Tint", ST);
            //Debug.Log(RenderSettings.skybox.GetColor("_SkyTint"));
        }
    }
    //public void changeFloor(Color GT)
    //{
    //    if (RenderSettings.skybox.HasProperty("_GroundColor"))
    //    {
    //        RenderSettings.skybox.SetColor("_GroundColor", GT);
    //        //Debug.Log(RenderSettings.skybox.GetColor("_GroundColor"));
    //    }
    //}
    //public void changeExpo(float ET)
    //{
    //    if (RenderSettings.skybox.HasProperty("_Exposure"))
    //    {
    //        RenderSettings.skybox.SetFloat("_Exposure", ET);
    //        //Debug.Log(RenderSettings.skybox.GetFloat("_Exposure"));
    //    }
    //}
}

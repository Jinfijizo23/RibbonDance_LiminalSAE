using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyMaster : MonoBehaviour {

    public Color Nextcolor;
    public GameObject MasterObject;
    public GameObject Hunter;

    public void changeTint(Color ST)
    {
        Nextcolor = ST;
        StartCoroutine(nowchanging(Nextcolor));
    }
    IEnumerator nowchanging(Color targetcolor)
    {
        float t = 0.0f;
        if (RenderSettings.skybox.HasProperty("_Tint"))
        {
            Color Currentcolor = RenderSettings.skybox.GetColor("_Tint");
            while (t < 1.0f)
            {
                t += 0.1f * Time.deltaTime;
                Debug.Log(t);
                RenderSettings.skybox.SetColor("_Tint", Color.Lerp(Currentcolor, targetcolor,t));
                yield return null;
            }
        }
        
       // Debug.Log("Sky Changed");
    }
}

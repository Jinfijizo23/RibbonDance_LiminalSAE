using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpSkybox2 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        //Call this function when you want to change colors from the exisint ones to the SkyTint and GroundColor
        //The skybox must be set to a procedural skybox material
        StartCoroutine(LerpSkybox(Color.blue));

    }

    IEnumerator LerpSkybox(Color targetSkyTint)
    {
        Debug.Log("Staring co-routine LerpSkybox");

        float t = 0.0f;
        Color currentSkyTint = RenderSettings.skybox.GetColor("_Tint");

        while (t < 1.0f)
        {
            //
            t += 0.1f * Time.deltaTime;
            Debug.Log(t);
            //

            RenderSettings.skybox.SetColor("_Tint", Color.Lerp(currentSkyTint, targetSkyTint, t));

            yield return null;
        }

        print("LerpSkybox is now finished.");

    }
}

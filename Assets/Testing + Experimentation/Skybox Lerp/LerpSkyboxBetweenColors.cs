using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpSkyboxBetweenColors : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //Call this function when you want to change colors from the exisint ones to the SkyTint and GroundColor
        //The skybox must be set to a procedural skybox material
        StartCoroutine(LerpSkybox(Color.red, Color.blue));

    }

    // Update is called once per frame
    void Update()
    {



    }

    IEnumerator LerpSkybox(Color targetSkyTint, Color targetGroundColor)
    {
        Debug.Log("Staring co-routine LerpSkybox");

        float t = 0.0f;
        Color currentSkyTint = RenderSettings.skybox.GetColor("_SkyTint");
        Color currentGroundColor = RenderSettings.skybox.GetColor("_GroundColor");

        while (t < 1.0f)
        {
            //
            t += 0.1f * Time.deltaTime;
            Debug.Log(t);
            //

            RenderSettings.skybox.SetColor("_SkyTint", Color.Lerp(currentSkyTint, targetSkyTint, t));
            RenderSettings.skybox.SetColor("_GroundColor", Color.Lerp(currentGroundColor, targetGroundColor, t));

            yield return null;
        }

        print("LerpSkybox is now finished.");

    }
}
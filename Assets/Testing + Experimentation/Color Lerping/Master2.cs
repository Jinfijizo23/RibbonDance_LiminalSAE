using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master2 : MonoBehaviour
{
    public GameObject MasterObject;
    public GameObject Victim;
    private Renderer R;
    public Tp2 Change;
    public GameObject Hunter;

    public Color CurrentColor;
    public Color NewColor;
    private float starttime;
    private float t;

    // Use this for initialization
    void Start()
    {
        R = Victim.GetComponent<Renderer>();
        CurrentColor = Victim.GetComponent<Renderer>().material.color;      
        starttime = Time.time;
    }

    public void changecolor(Color cl)
    {
        NewColor = cl;
        StartCoroutine(ChangeNew());
    }
    //IEnumerator ChangeNew()
    //{
    //    Debug.Log("Commence change");
    //    while (t <= 1.0f)
    //    {
    //        t += 0.1f * Time.deltaTime;
    //        Debug.Log("t = " + t);
    //    }
    //    R.material.color = Color.Lerp(CurrentColor, NewColor, t);
    //    yield return new WaitForSeconds(5.0f);
    //        t = 0.0f;
    //        CurrentColor = NewColor;
    //        Debug.Log("change complete");     
    //}
    IEnumerator ChangeNew()
    {
        //Debug.Log("Staring co-routine LerpSkybox");
        t = 0.0f;
        Color Nextcolor = NewColor;
        Color currentSkyTint = CurrentColor;

        while (t < 1.0f)
        {
            //
            t += 0.3f * Time.deltaTime;
            //Debug.Log(t);
            //
            CurrentColor = Color.Lerp(currentSkyTint, Nextcolor, t);
            //Debug.Log(CurrentColor);
            yield return null;
        }

        //print("LerpSkybox is now finished.");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnaround : MonoBehaviour {

    public GameObject[] Prefabs;
    public int prefabnumber = 3;
    public Vector3 SpawnValues;
    public float SpawnWait;
    public float SpawnMostWait;
    public float SpawnLeastWait;
    public int StartWait;
    public bool stop;
    public float TimeIndicator = 150;

    int randobject;
     void Start()
    {
         Debug.Log("first Wave");
         StartCoroutine(waitSpawner1st());
    }
    void Update()
    {
        SpawnWait = Random.Range(SpawnLeastWait, SpawnMostWait);   
        TimeIndicator -= Time.deltaTime;
        if (TimeIndicator <= 0)
        {
            Debug.Log("second wave");
            prefabnumber = 5;
        }           
    }
    IEnumerator waitSpawner1st()
    {
          yield return new WaitForSeconds (StartWait);  
        while(!stop)
        {
            randobject = Random.Range(0, prefabnumber);
            Vector3 spawnPoint = new Vector3(Random.Range(-SpawnValues.x, SpawnValues.x), Random.Range(-SpawnValues.y, SpawnValues.y), Random.Range(-SpawnValues.z, SpawnValues.z));
            Instantiate(Prefabs[randobject],spawnPoint + transform.TransformPoint(0,0,0), gameObject.transform.rotation);
            yield return new WaitForSeconds(SpawnWait);
        }
     }
}

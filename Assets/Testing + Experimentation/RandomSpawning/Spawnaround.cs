using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnaround : MonoBehaviour {

    public GameObject[] Prefabs;
    public Vector3 SpawnValues;
    public float SpawnWait;
    public float SpawnMostWait;
    public float SpawnLeastWait;
    public int StartWait;
    public bool stop;

    int randobject;

    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    void Update()
    {
        SpawnWait = Random.Range(SpawnLeastWait, SpawnMostWait);
    }
    IEnumerator waitSpawner()
    {
          yield return new WaitForSeconds (StartWait);  
        while(!stop)
        {
            randobject = Random.Range(0, 5);
            Vector3 spawnPoint = new Vector3(Random.Range(-SpawnValues.x, SpawnValues.x), Random.Range(-SpawnValues.y, SpawnValues.y), Random.Range(-SpawnValues.z, SpawnValues.z));
            Instantiate(Prefabs[randobject],spawnPoint + transform.TransformPoint(0,0,0), gameObject.transform.rotation);
            yield return new WaitForSeconds(SpawnWait);
        }
     }
}

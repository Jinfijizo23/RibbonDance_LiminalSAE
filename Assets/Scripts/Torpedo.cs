using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torpedo : MonoBehaviour {

    public GameObject frontObject;
    public float distance;
    public float Speed;

    public float setDistance = 3;

    RaycastHit hit;

    public bool running = false;

    void Update()
    {
        FireballPosition();

        int layer_mask = LayerMask.GetMask("Firework");

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(transform.position, forward, Color.green);



        // if Raycast hits something = frontobject will snap to that something.
        //if (Physics.Raycast(transform.position, (forward), out hit))
        //{
        //    if (hit.collider.gameObject.tag == "Firework")
        //    {
        //        frontObject.transform.position = hit.point;
        //    }
        //    else
        //    {
        //        FireballPosition();
        //    }
        //}

        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) || Input.GetButtonDown("Jump"))
        {
            running = true;
        }

        if(OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger) || Input.GetButtonUp("Jump"))
        {
            running = false;
        }

        if(running == true)
        {
            distance += Speed;
        }
        else
        {
            distance -= Speed;
        }
        
        if(distance <= setDistance)
        {
            distance = setDistance;
        }

        if(distance >= 20)
        {
            distance = 20;
        }

    }

    void FireballPosition()
    {
        frontObject.transform.position = gameObject.transform.position + gameObject.transform.forward * distance;
    }
}


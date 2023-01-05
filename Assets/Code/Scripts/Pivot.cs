using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour {

    public Transform drone;
    public Vector3 offset;

    // Update is called once per frame
    void Update() {
        transform.position = drone.position + offset;
        Quaternion pivotRotation = drone.rotation;
        //pivotRotation.y = 0;
        pivotRotation.x = 0;
        pivotRotation.z = 0;
        //pivotRotation.w = 0;
        transform.rotation = pivotRotation;
    }
}

/*
        if (!fpv) {
            transform.position = drone.position + offset;
        } else {
            transform.position = drone.position;
        }

        if (Input.GetKeyDown("f"))
        {
            fpv = !fpv;
        }

*/
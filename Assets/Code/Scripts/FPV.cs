using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPV : MonoBehaviour
{
    public Camera cam;
    public Rigidbody drone;
    bool fpv = false;
    public Vector3 offset = new Vector3(0, (float)1.5, -2);

    // Update is called once per frame
    void Update()
    {

/*
        if (!fpv) {
            transform.position = drone.position + offset;
        } else {
            transform.position = drone.position;
        }
        */

        if (Input.GetKeyDown("f"))
        {
            fpv = !fpv;
            if (fpv) {
                transform.localPosition -= offset;
            } else {
                transform.localPosition += offset;
            }
        }
    }
}

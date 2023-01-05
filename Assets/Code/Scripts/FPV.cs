using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPV : MonoBehaviour
{
    public Camera cam;
    public Rigidbody drone;
    bool fpv = false;
    public Vector3 offset = new Vector3(0, (float)1.5, -2);
    public Text indicator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            fpv = !fpv;
            if (fpv) {
                transform.localPosition -= offset;
                indicator.text = "FPV ON (f to toggle)";
                indicator.color = new Color(0,(float)0.5,0);
            } else {
                transform.localPosition += offset;
                indicator.text = "FPV OFF (f to toggle)";
                indicator.color = new Color((float)0.5,0,0);
            }
        }
    }
}

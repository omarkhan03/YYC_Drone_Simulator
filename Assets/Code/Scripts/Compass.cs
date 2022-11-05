using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public Transform droneTransform;
    Vector3 dir;

    private void Update()
    {
        dir.z = droneTransform.eulerAngles.y - 90;
        transform.localEulerAngles = dir;
    }
}

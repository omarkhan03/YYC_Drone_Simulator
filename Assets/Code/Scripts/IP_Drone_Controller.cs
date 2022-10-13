using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[RequireComponent(typeof(IP_Drone_Inputs))]
public class IP_Drone_Controller : IP_Base_Rigidbody
{
    #region Variables
    [Header("Control Properties")]
    [SerializeField] private float minMaxPitch = 30f;
    [SerializeField] private float minmaxRoll = 30f;
    [SerializeField] private float yawPower = 1f;
    [SerializeField] private float lerpSpeed = 0.5f;

    private IP_Drone_Inputs input;
    private List<IEngine> engines = new List<IEngine>();

    private float finalPitch;
    private float finalRoll;
    private float yaw;
    private float finalYaw;
    #endregion

    #region Main Methods
    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<IP_Drone_Inputs>();
        engines = GetComponentsInChildren<IEngine>().ToList<IEngine>();    
    }
    #endregion

    #region Custom Methods
    protected override void HandlePhysics()
    {
        HandleEngines();
        HandleControls();
    }

    protected virtual void HandleEngines()
    {     
        foreach(IEngine engine in engines) {
            engine.UpdateEngine(rb, input);
        }
    }

    protected virtual void HandleControls()
    {
        float pitch = input.Cyclic.y * minMaxPitch;
        float roll = -input.Cyclic.x * minmaxRoll;
        yaw += input.Pedals * yawPower;

        finalPitch = Mathf.Lerp(finalPitch, pitch, Time.deltaTime * lerpSpeed);
        finalRoll = Mathf.Lerp(finalRoll, roll, Time.deltaTime * lerpSpeed);
        finalYaw = Mathf.Lerp(finalYaw, yaw, Time.deltaTime * lerpSpeed);

        Quaternion rot = Quaternion.Euler(finalPitch, finalYaw, finalRoll);
        rb.MoveRotation(rot);
    }
    #endregion
}

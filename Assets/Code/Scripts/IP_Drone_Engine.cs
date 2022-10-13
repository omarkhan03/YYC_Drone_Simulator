using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class IP_Drone_Engine : MonoBehaviour, IEngine
{
    #region Variables
    [Header("Engine Properties")]
    [SerializeField] private float maxPower = 4f;
    [SerializeField] private float extraPower = 10f;

    [Header("Propeller Properties")]
    [SerializeField] private Transform propeller;
    [SerializeField] private float propRotSpeed = 300f;
    #endregion

    #region Interface Methods
    public void InitEngine()
    {
        
    }

    public void UpdateEngine(Rigidbody rb, IP_Drone_Inputs input)
    {
        Vector3 upVec = transform.up;
        upVec.x = 0f;
        upVec.z = 0f;
        float diff = 1 - upVec.magnitude;
        float finalDiff = Physics.gravity.magnitude * diff;

        Vector3 engineForce = Vector3.zero;
        engineForce = transform.up * ((rb.mass * Physics.gravity.magnitude) + finalDiff + (input.Throttle * maxPower)) / 4f;
        
        rb.AddForce(engineForce, ForceMode.Force);
        HandlePropellers();

        float power = input.Pedals;
        float x = input.Cyclic.x;
        float y = input.Cyclic.y;

        Vector3 extra = new Vector3 (x, 0f, y) * extraPower;
        rb.AddForce(extra);
    }

    public void ExtraForce(Rigidbody rb, IP_Drone_Inputs input) {
        /*
        float power = input.Pedals * extraPower;
        float x = input.Cyclic.x;
        float y = input.Cyclic.y;

        Vector3 extra = new Vector3 (x, 0f, y) * power;
        rb.AddForce(extra);
        */
        /*
         if ( Input.GetKey("i")) {
            drone.AddForce(sidewaysForce*Time.deltaTime*Camera.main.transform.forward);
        } 
        if ( Input.GetKey("k")) {
            drone.AddForce(-sidewaysForce*Time.deltaTime*Camera.main.transform.forward);
        }
        if ( Input.GetKey("j")) {
            drone.AddForce(-sidewaysForce*Time.deltaTime*Camera.main.transform.right);
        } 
        if ( Input.GetKey("l")) {
            drone.AddForce(sidewaysForce*Time.deltaTime*Camera.main.transform.right);
        } 
        */
    }

    void HandlePropellers()
    {
        if(!propeller) {
            return;
        }

        propeller.Rotate(Vector3.up, propRotSpeed);
    }
    #endregion
}

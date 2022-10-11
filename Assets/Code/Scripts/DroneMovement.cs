using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DroneMovement : MonoBehaviour
{
    public Rigidbody drone;

    void Update() {

    }

    private void OnMove(InputValue value) {
        Debug.Log(value.Get<float>());
    }

// Old movement code:
/*
    public float upwardForce = 1000f;
    public float sidewaysForce = 500f;
    public float maxSpeed = 1f;


    void Start() {
        // No rotation on drone.
        drone.freezeRotation = true;
    }

    void Update() {

        // Setting a max velocity on drone
        if(drone.velocity.magnitude > maxSpeed)
         {
            drone.velocity = drone.velocity.normalized * maxSpeed;
         }

        if ( Input.GetKey("w")) {
            drone.AddForce(0, upwardForce * Time.deltaTime, 0);
        }   

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
    }

    // When the drone hits the floor, it loses all velocity
    void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Environment") {
            drone.velocity = new Vector3(0,0,0);
        }
    }
*/
}

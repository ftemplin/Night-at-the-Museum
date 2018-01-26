using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour {
    private Rigidbody rigidbody;
    public float walkSpeed = 1;
    public float turnSpeed = 1;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	
	void FixedUpdate () {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");
        rigidbody.velocity = transform.forward * moveVertical * walkSpeed;
        rigidbody.angularVelocity = transform.up * moveHorizontal * turnSpeed;

    }
}

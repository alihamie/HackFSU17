using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan_float : MonoBehaviour {
    public int fan_force;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Applies an upwards force to all rigidbodies that enter the trigger.
    void OnTriggerStay(Collider other) {
        if (other.attachedRigidbody)
            other.attachedRigidbody.AddForce(Vector3.up * fan_force);
    }
}

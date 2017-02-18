using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineEffect : MonoBehaviour {

    public float bounceFactor = 100f;
    void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * bounceFactor);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

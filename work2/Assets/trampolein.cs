using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampolein : MonoBehaviour {
    float Jumping = 20;
    public Rigidbody actor;
	// Use this for initialization
	void Start () {
        actor = GetComponent<Rigidbody>();
	}
	
	void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "goup")
        {
            actor.velocity = new Vector3(0, Jumping, Jumping);
        }
	}
}

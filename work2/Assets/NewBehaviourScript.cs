using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject ballsack;
	// Use this for initialization
	void Start () {
        ballsack.SetActive(true);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        ballsack.SetActive(false);
    }
}

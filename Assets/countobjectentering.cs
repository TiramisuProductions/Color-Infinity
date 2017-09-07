using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countobjectentering : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Object Detected");
		StaticShare.objbordercounter++;
		}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroybycollision : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other) {
		//you may check the tag of the 'other' object here to make sure if its your instantiated object
		if (other.gameObject.tag == "collisionquad") {
		} else if (other.gameObject.tag == "lowborder") {
		} else if (other.gameObject.tag == "lowerborderpart") {
		}
		else {
			Destroy (other.gameObject);
		}
		//dont forget to check the isTrigger of the quad or else the event will not trigger
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touchtest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButtonDown (0) || (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began)) {

			Debug.Log ("tupperware");

			Ray ray;
			{
				//Debug.Log("Touch detected.");

				RaycastHit hit;
				//Ray ray = Camera.main.ScreenPointToRay((Input.GetTouch(0).position));
				if (Input.GetMouseButtonDown (0)) {
					ray = Camera.main.ScreenPointToRay ((Input.mousePosition));
				} else {
					ray = Camera.main.ScreenPointToRay ((Input.GetTouch (0).position));
				}
				if (Physics.Raycast (ray, out hit)) {
					//	Debug.Log("Raycast hit " + hit.collider.name);
					//	Debug.Log("Raycast tag " + hit.collider.gameObject.tag);

					Debug.Log ("tappu" + hit.collider.gameObject.tag);

				}}
		}
		
	}
}

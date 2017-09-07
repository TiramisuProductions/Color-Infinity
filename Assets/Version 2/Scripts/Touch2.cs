using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touch2 : MonoBehaviour {

	// Use this for initialization
	public GameObject explosion, GameControllerObject,DestroyAudio1,DestroyAudio2;
	bool clicked;
	public Text scoretext;
	GameObject ResumePanel;


	// Use this for initialization
	void Start()
	{
		GameControllerObject = GameObject.FindGameObjectWithTag("gamecontroller");
		// DestroyAudio1 = GameObject.FindGameObjectWithTag("DestroyAudio1");
		//DestroyAudio2 = GameObject.FindGameObjectWithTag("DestroyAudio2");
		gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color",StaticShare.objectcolor);

	}

	// Update is called once per frame
	void Update()
	{
		clicked = false;

//		Debug.Log("foo",gameObject);

		if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) )
		{
			if(clicked == false)
			{
				clicked = true;

			Debug.Log ("shammu");



			Ray ray;
			{
				//Debug.Log("Touch detected.");

				RaycastHit hit;
				//Ray ray = Camera.main.ScreenPointToRay((Input.GetTouch(0).position));
				if (Input.GetMouseButtonDown(0))
				{ ray = Camera.main.ScreenPointToRay((Input.mousePosition)); }
				else
				{
					ray = Camera.main.ScreenPointToRay((Input.GetTouch(0).position));
				}
				if (Physics.Raycast(ray, out hit))
				{
					//	Debug.Log("Raycast hit " + hit.collider.name);
					//	Debug.Log("Raycast tag " + hit.collider.gameObject.tag);
					if (hit.collider.gameObject.tag != "border") {
						Debug.Log ("fuck" + hit.collider.gameObject.tag);

							if (StaticShare.inverse == false) {
					
								if (hit.transform.gameObject.GetComponent<MeshRenderer> ().material.color == StaticShare.currentbordercolor) {
									GameControllerObject.GetComponent<GameController2> ().score++;
									Debug.Log ("SCORED" + GameControllerObject.GetComponent<GameController2> ().score);

									GameControllerObject.GetComponent<GameController2> ().scoreText.text = "" + GameControllerObject.GetComponent<GameController2> ().score;
									// scoreText.text = "";
									StartCoroutine (ExecuteAfterTime (3));
								} else {
									
									StaticShare.gameend = true;

								}
							} else {

								if (hit.transform.gameObject.GetComponent<MeshRenderer> ().material.color != StaticShare.currentbordercolor) {
									GameControllerObject.GetComponent<GameController2> ().score++;
									Debug.Log ("SCORED" + GameControllerObject.GetComponent<GameController2> ().score);

									GameControllerObject.GetComponent<GameController2> ().scoreText.text = "" + GameControllerObject.GetComponent<GameController2> ().score;
									// scoreText.text = "";
									StartCoroutine (ExecuteAfterTime (3));
								} else {
									
									StaticShare.gameend = true;

								}


							}
							Vector3 t = hit.collider.transform.position;
							explosion = (GameObject)Instantiate (explosion, t, Quaternion.identity); 
							if (hit.transform.gameObject != null) {
								
								Destroy (hit.transform.gameObject);
							}
						

						//Debug.Log("Color");
						//  Debug.Log("The tag matches.");
						//Destroy(hit.collider.gameObject);
						//Debug.Log ("fucking" + hit.collider.gameObject.tag);
						                
						Destroy (explosion, 1);
					}
				}
			}
		}
	}
}





IEnumerator ExecuteAfterTime(float time)
{

	yield return new WaitForSeconds(time);
		GameControllerObject.GetComponent<GameController2> ().scoreText.text = "";
	// Code to execute after the delay
}

}

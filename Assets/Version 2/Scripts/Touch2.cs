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
	

	}

	// Update is called once per frame
	void Update()
	{
		clicked = false;

//		Debug.Log("foo",gameObject);

		if (Input.GetMouseButtonDown (0) || (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began)) {
			if (StaticShare.isgamestarted == true) {

				if (clicked == false) {
					clicked = true;

					Debug.Log ("shammu");



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
							if (hit.collider.gameObject.tag != "border") {

								if (hit.collider.gameObject != null) {
									Debug.Log ("fuck" + hit.collider.gameObject.GetComponent<ColorByOffset>().objectcolor);
									Debug.Log ("Shit" + StaticShare.currentbordercolor);


							
									Destroy (explosion, 1);
								}
							}
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderColorManager : MonoBehaviour {

	public Vector2 purple = new Vector2 (0.73f, -0.97f);
	public Vector2 red = new Vector2 (0.73f, -0.04f);
	public GameObject gamecontrollerobject;
	public string tempcolor;
	public int counter;

	// Use this for initialization
	void Start () {
		gamecontrollerobject = GameObject.FindGameObjectWithTag ("gamecontroller");

	
		counter = 0;
		gameObject.GetComponent<Renderer> ().material.mainTextureOffset = colorchooselevel1 ();
		StaticShare.currentbordercolor = tempcolor;

		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	public void colorchange()
	{
		StartCoroutine (Wait (0.5f));




		counter = 0;
		gameObject.GetComponent<Renderer> ().material.mainTextureOffset = colorchooselevel1 ();
	}


	IEnumerator Wait(float duration)
	{
		yield return new WaitForSeconds (duration);
		StopCoroutine (Wait (0.5f));
	}


	Vector2 colorchooselevel1()
	{

		int j  = Random.Range (0, 3);

		switch (j) {

		case 0:
			
			tempcolor = "purple";
			return purple;
			break;
		case 1:
			tempcolor = "red";
			return red;

			break;
		case 2:
			return purple;
			break;
		case 3:
			return purple;
			break;
		default:
			return purple;
		}

	}
}

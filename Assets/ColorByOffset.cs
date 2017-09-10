using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorByOffset : MonoBehaviour {


	public string objectcolor;
	Vector2 red = new Vector2 (0.73f, 0.2f);
	Vector2 purple = new Vector2 (0.73f, 0.0f);
	// Use this for initialization
	void Start () {
		objectcolor = StaticShare.objectcolor;


		gameObject.GetComponent<Renderer> ().material.mainTextureOffset = choosecolor();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public Vector2  choosecolor()
	{

		switch (objectcolor) {
		case "red":
			
			return red;
			break;
		case "purple":
			
			return purple;
			break;
			default:
			return purple;
			break;
			
			

		}


	}

}

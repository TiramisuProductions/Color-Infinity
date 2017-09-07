using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modselector : MonoBehaviour {

	public Texture noninverse, inverse;

	// Use this for initialization
	void Start () {

		GetComponent<Renderer> ().material.SetTexture("_MainTex",noninverse);
		
	}
	
	// Update is called once per frame
	void Update () {

		if (StaticShare.inverse == true) {
			GetComponent<Renderer> ().material.SetTexture("_MainTex",inverse);
		} else {
			GetComponent<Renderer> ().material.SetTexture("_MainTex",noninverse);
		}
		
	}
}

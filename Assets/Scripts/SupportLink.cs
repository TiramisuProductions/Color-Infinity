using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportLink : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Supportlink()
	{
		Application.OpenURL ("http://www.patreon.com/tiramisugames");
	}
}

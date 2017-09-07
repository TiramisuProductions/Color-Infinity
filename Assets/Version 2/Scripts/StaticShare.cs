using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticShare : MonoBehaviour {


	public static Color objectcolor;
	public static Color currentbordercolor;
	public static int objbordercounter;
	public static bool inverse;
	public static bool gameend;
	// Use this for initialization
	void Start () {
		objectcolor = Color.red;
		objbordercounter = 0;
		gameend = false;
		inverse = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

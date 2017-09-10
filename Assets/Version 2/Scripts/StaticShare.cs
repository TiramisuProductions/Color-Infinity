using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticShare : MonoBehaviour {


	public static string objectcolor;
	public static string currentbordercolor;
	public static int objbordercounter;
	public static bool inverse;
	public static bool gameend;
	public static bool isgamestarted;
	// Use this for initialization
	void Start () {
		
		objbordercounter = 0;
		gameend = false;
		inverse = false;
		isgamestarted = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void start()
	{
		Time.timeScale = 1;
		GameObject[] enemies = GameObject.FindGameObjectsWithTag("object");
		foreach(GameObject enemy in enemies)
			GameObject.Destroy(enemy);

		GameObject game = GameObject.FindGameObjectWithTag ("gamecontroller");
		game.GetComponent<GameController2> ().levelcounter = 1;
		StaticShare.isgamestarted = true;

	}
	}



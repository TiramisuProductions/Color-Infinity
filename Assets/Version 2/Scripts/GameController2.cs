using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController2 : MonoBehaviour {

	public GameObject level1hazard1, level1hazard2, level1hazard3,level1hazard4;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public int sameobjectcounter;
	public int level1intervalsamecolor;
	public int counter;
	public int objectpassed;
	public int levelcounter;
	public int score ;
	public GameObject borderobject;
	public GameObject exitpanel;
	public GameObject exitpanelmainmenu;
	public GameObject exitpanelbtn;
	public Text scoreText;


	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnWaves ());
		levelcounter = 1;
		level1intervalsamecolor = 2;

		counter = 0;
		score = 0;
		borderobject = GameObject.FindGameObjectWithTag ("border");
		scoreText.text = " ";

	}




	
	// Update is called once per frame
	void Update () {

		Debug.Log ("siddy" + StaticShare.gameend);
		if (StaticShare.gameend == true) {
			exitpanel.SetActive (true);
			int children = transform.childCount;

			foreach (Transform child in exitpanel.GetComponentInChildren<Transform> ())
			{
				child.gameObject.SetActive(true);
			}
			exitpanelbtn.GetComponent<Text> ().text = "Your Score is " + score;

			//Time.timeScale = 0;
			StaticShare.gameend = false;
			score = 0;
			//StartCoroutine (ExecuteAfterTime (1));

		}
	}


	string colorchooselevel1()
	{
		int i = Random.Range (0, 2);

		switch (i) {

		case 0:
			return "red";
		case 1: 
			return "purple";
		default:
			return "red";
		}

	}






	IEnumerator ExecuteAfterTime(float time)
	{

		yield return new WaitForSeconds(time);
		Time.timeScale = 0;
		// Code to execute after the delay
	}




	public IEnumerator SpawnWaves()
	{
		while (true) {
			objectpassed++;

			if (objectpassed == 10) {
				spawnWait = 2;
				objectpassed = 0;
				Debug.Log ("Color Change");
				counter = 0;
				borderobject.GetComponent<BorderColorManager> ().colorchange ();
				levelcounter++;
			} else {
				spawnWait = 1.5f;
			}
			counter++;


			if (counter%2 == 0) {
				
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				levelselecter (levelcounter, false);
			} else {
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				levelselecter (levelcounter, true);
			}
			yield return new WaitForSeconds(spawnWait);
		}

	}


	public void levelselecter(int level,bool border)
	{
		Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		switch (level) {

		case 1:
			if (border) {
				StaticShare.objectcolor = StaticShare.currentbordercolor;
			} else {
				StaticShare.objectcolor = colorchooselevel1();
			}
		
			Instantiate(level1hazard1, spawnPosition, spawnRotation);
			
			
			break;

		}
			


		

			
		}
	}











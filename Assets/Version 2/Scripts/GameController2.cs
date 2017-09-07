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

	GameObject hazardchooselevel1(bool bordercolor)
	{
		int i = Random.Range (0, 2);

		if (bordercolor) {
			StaticShare.objectcolor = StaticShare.currentbordercolor;
			//level1hazard1.GetComponent<MeshRenderer> ().material.SetColor ("_Color", Color.yellow);
			return level1hazard1;
		} else if (i == 0) {
			StaticShare.objectcolor = level1color ();
			return level1hazard3;
		} else {
			StaticShare.objectcolor = level1color ();
			return level1hazard1;
		}
		
	}

	GameObject hazardchooselevel2(bool bordercolor)
	{
		if (bordercolor) {
			StaticShare.objectcolor = StaticShare.currentbordercolor;
			//level1hazard1.GetComponent<MeshRenderer> ().material.SetColor ("_Color", Color.yellow);
			return level1hazard2;
		} else {
			StaticShare.objectcolor = level1color();
			return level1hazard4;
		}
	}


	GameObject hazardchooselevel3(bool bordercolor)
	{
		if (bordercolor) {
			StaticShare.objectcolor = StaticShare.currentbordercolor;
			//level1hazard1.GetComponent<MeshRenderer> ().material.SetColor ("_Color", Color.yellow);
			return level1hazard2;
		} else {
			StaticShare.objectcolor = level1color();
			return level1hazard1;
		}
	}

	GameObject hazardchooselevel4(bool bordercolor)
	{
		if (bordercolor) {
			StaticShare.objectcolor = StaticShare.currentbordercolor;
			//level1hazard1.GetComponent<MeshRenderer> ().material.SetColor ("_Color", Color.yellow);
			return level1hazard3;
		} else {
			StaticShare.objectcolor = level1color();
			return level1hazard1;
		}
	}




	IEnumerator ExecuteAfterTime(float time)
	{

		yield return new WaitForSeconds(time);
		Time.timeScale = 0;
		// Code to execute after the delay
	}


	Color  level1color()
	{
		int c = Random.Range (0, 3);

		switch (c) {

		case 0:
			return Color.red;

		case 1:
			return Color.yellow;

		default:
			return Color.blue;
			
		}
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
			Vector3 spawnPosition2 = new Vector3 (-90, 0, -180);
			Quaternion spawnRotation2 = Quaternion.Euler (-90, 0, 180);
			Instantiate (hazardchooselevel1 (border), spawnPosition2, spawnRotation2);
			StaticShare.inverse = false;
			break;
		case 2:
			Vector3 spawnPosition4 = new Vector3 (-90, 0, -180);
			Quaternion spawnRotation4 = Quaternion.Euler (-90, 0, 180);
			Instantiate (hazardchooselevel2 (border), spawnPosition4, spawnRotation4);
			StaticShare.inverse = false;
			break;
		case 3:
			Vector3 spawnPosition5 = new Vector3 (-90, 0, -180);
			Quaternion spawnRotation5 = Quaternion.Euler (-90, 0, 180);
			Instantiate (hazardchooselevel3 (border), spawnPosition5, spawnRotation5);
			StaticShare.inverse = false;
			break;
		case 4:
			Vector3 spawnPosition3 = new Vector3 (-90, 0, -180);
			Quaternion spawnRotation3 = Quaternion.Euler (-90, 0, 180);
			Instantiate (hazardchooselevel4 (border), spawnPosition3, spawnRotation3);
			StaticShare.inverse = true;
			break;
		

			
		}
	}









}

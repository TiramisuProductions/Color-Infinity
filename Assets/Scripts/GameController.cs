using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public GameObject level1hazard1, level1hazard2, level1hazard3;
	public GameObject level2hazard1, level2hazard2, level2hazard3;
	public GameObject level3hazard1, level3hazard2, level3hazard3;
	public GameObject level4hazard1, level4hazard2, level4hazard3;
	public GameObject level5hazard1, level5hazard2, level5hazard3;
	public GameObject level6hazard1, level6hazard2, level6hazard3;
	public GameObject level7hazard1, level7hazard2, level7hazard3;
	public GameObject level8hazard1, level8hazard2, level8hazard3;
	public GameObject level9hazard1, level9hazard2, level9hazard3;
	public GameObject level10hazard1,level10hazard2,level10hazard3;


	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public Text scoreText;
	public int score ;
	public  int level = 1;
	public float playedtime = 0;
	public bool newlevel = true;
	public bool gameend;
	public bool gamepause;
	public GUIText Inversetext;
	public GameObject Background;

	public  bool inverse = false;

	private int counter;
	private bool waitinverse,waitnoninverse;




	void Start()
	{

		inverse = false;
		gameend = false;
		gamepause = false;
		scoreText.text = " ";
		Time.timeScale = 1;
		counter = 0;
		score = 0;
		//UpdateScore ();
		StartCoroutine(SpawnWaves());

		Background = GameObject.FindGameObjectWithTag("Background");


		Destroy(AdManager.Instance);


	}


	void Update()
	{
		//scoreText.text = "" + level+"t"+playedtime; 

		playedtime = Time.deltaTime + playedtime;


		if (playedtime > 20 && playedtime <40)
		{
			Background.GetComponent<Renderer>().material.color = Color.red;
			level = 1;
			waveWait = 1;


			if (playedtime > 26)
			{

			}
			// Debug.Log("Reached Level 2 ");
			waitinverse = true;

		}
		else if (playedtime > 40 && playedtime < 80)
		{
			if (waitinverse) {
				waveWait = 10;
			}
			if (waitinverse&& !GameObject.FindGameObjectWithTag("red")&&!GameObject.FindGameObjectWithTag("orange")&&!GameObject.FindGameObjectWithTag("yellow")
				&&!GameObject.FindGameObjectWithTag("brown")&&!GameObject.FindGameObjectWithTag("pink")&&!GameObject.FindGameObjectWithTag("white")&&!GameObject.FindGameObjectWithTag("green")
				&&!GameObject.FindGameObjectWithTag("purple")) {
				waveWait = 1;
				level = 3;
				inverse = true;
				//  Debug.Log("Reached Level 3");
				waitinverse = false;
				waitnoninverse = true;
			}



		}

		else if (playedtime > 80 && playedtime < 120)
		{

			//yield return new WaitForSeconds(10);

			if (waitnoninverse) {
				waveWait = 10;
			}
			if (waitnoninverse&& !GameObject.FindGameObjectWithTag("red")&&!GameObject.FindGameObjectWithTag("orange")&&!GameObject.FindGameObjectWithTag("yellow")
				&&!GameObject.FindGameObjectWithTag("brown")&&!GameObject.FindGameObjectWithTag("pink")&&!GameObject.FindGameObjectWithTag("white")&&!GameObject.FindGameObjectWithTag("green")
				&&!GameObject.FindGameObjectWithTag("purple")) {
				waveWait = 2;
				level = 4;
				inverse = false;
				//  Debug.Log("Reached Level 3");
				waitinverse = true;
				waitnoninverse = false;
			}








			//   Debug.Log("Reached Level 4");
		}

		else if (playedtime > 120 && playedtime < 160)
		{
			if (counter == 0)
			{
				playedtime = 10;
				counter++;
			}
			else
			{
				//wait = true;
				if (waitinverse) {
					waveWait = 10;
				}
				if (waitinverse&& !GameObject.FindGameObjectWithTag("red")&&!GameObject.FindGameObjectWithTag("orange")&&!GameObject.FindGameObjectWithTag("yellow")
					&&!GameObject.FindGameObjectWithTag("brown")&&!GameObject.FindGameObjectWithTag("pink")&&!GameObject.FindGameObjectWithTag("white")&&!GameObject.FindGameObjectWithTag("green")
					&&!GameObject.FindGameObjectWithTag("purple")) {
					waveWait = 3;
					level = 5;
					inverse = true;
					//  Debug.Log("Reached Level 3");
					waitinverse = false;
					waitnoninverse = true;
				}


			}


			// Debug.Log("Reached Level 5");

		}

		else if (playedtime > 160 && playedtime < 200)
		{

			//  Debug.Log("Reached Level 6");
			if (counter == 1)
			{
				playedtime = 40;
				counter++;
			}

			else
			{
				if (waitnoninverse) {
					waveWait = 10;
				}
				if (waitnoninverse&& !GameObject.FindGameObjectWithTag("red")&&!GameObject.FindGameObjectWithTag("orange")&&!GameObject.FindGameObjectWithTag("yellow")
					&&!GameObject.FindGameObjectWithTag("brown")&&!GameObject.FindGameObjectWithTag("pink")&&!GameObject.FindGameObjectWithTag("white")&&!GameObject.FindGameObjectWithTag("green")
					&&!GameObject.FindGameObjectWithTag("purple")) {
					waveWait = 3;
					level = 6;
					inverse = false;
					//  Debug.Log("Reached Level 3");
					waitinverse = true;
					waitnoninverse = false;
				}
			}


		}

		else if (playedtime > 200 && playedtime < 240)
		{

			//  Debug.Log("Reached Level 7");

			if (counter == 2)
			{
				playedtime = 60;
				counter++;
			}

			else
			{
				if (waitinverse) {
					waveWait = 10;
				}
				if (waitinverse&& !GameObject.FindGameObjectWithTag("red")&&!GameObject.FindGameObjectWithTag("orange")&&!GameObject.FindGameObjectWithTag("yellow")
					&&!GameObject.FindGameObjectWithTag("brown")&&!GameObject.FindGameObjectWithTag("pink")&&!GameObject.FindGameObjectWithTag("white")&&!GameObject.FindGameObjectWithTag("green")
					&&!GameObject.FindGameObjectWithTag("purple")) {
					waveWait = 3;
					level = 7;
					inverse = true;
					//  Debug.Log("Reached Level 3");
					waitinverse = false;
					waitnoninverse = true;
				}


			}
		}


		else if (playedtime > 240 && playedtime < 280)
		{
			if (counter == 3)
			{
				playedtime = 80;
				counter++;
			}

			else
			{
				if (waitnoninverse) {
					waveWait = 10;
				}
				if (waitnoninverse&& !GameObject.FindGameObjectWithTag("red")&&!GameObject.FindGameObjectWithTag("orange")&&!GameObject.FindGameObjectWithTag("yellow")
					&&!GameObject.FindGameObjectWithTag("brown")&&!GameObject.FindGameObjectWithTag("pink")&&!GameObject.FindGameObjectWithTag("white")&&!GameObject.FindGameObjectWithTag("green")
					&&!GameObject.FindGameObjectWithTag("purple")) {
					waveWait = 3;
					level = 8;
					inverse = false;
					//  Debug.Log("Reached Level 3");
					waitinverse = true;
					waitnoninverse = false;
				}
			}
		}


		else if (playedtime > 280 && playedtime < 320)
		{
			if (counter == 4)
			{
				playedtime = 80;
				counter++;
			}

			else
			{
				if (waitinverse) {
					waveWait = 10;
				}
				if (waitinverse&& !GameObject.FindGameObjectWithTag("red")&&!GameObject.FindGameObjectWithTag("orange")&&!GameObject.FindGameObjectWithTag("yellow")
					&&!GameObject.FindGameObjectWithTag("brown")&&!GameObject.FindGameObjectWithTag("pink")&&!GameObject.FindGameObjectWithTag("white")&&!GameObject.FindGameObjectWithTag("green")
					&&!GameObject.FindGameObjectWithTag("purple")) {
					waveWait = 3;
					level = 9;
					inverse = true;
					//  Debug.Log("Reached Level 3");
					waitinverse = false;
					waitnoninverse = true;
				}


			}
		}

		else if (playedtime > 320 && playedtime < 360)
		{
			if (counter == 5)
			{
				playedtime = 100;
				counter++;
			}

			else
			{
				if (waitnoninverse) {
					waveWait = 10;
				}
				if (waitnoninverse&& !GameObject.FindGameObjectWithTag("red")&&!GameObject.FindGameObjectWithTag("orange")&&!GameObject.FindGameObjectWithTag("yellow")
					&&!GameObject.FindGameObjectWithTag("brown")&&!GameObject.FindGameObjectWithTag("pink")&&!GameObject.FindGameObjectWithTag("white")&&!GameObject.FindGameObjectWithTag("green")
					&&!GameObject.FindGameObjectWithTag("purple")) {
					waveWait = 3;
					level = 8;
					inverse = false;
					playedtime = 60;
					counter = 0;
					//  Debug.Log("Reached Level 3");
					waitinverse = true;
					waitnoninverse = false;
				}
			}
		}

	}








	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds(startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				int j;

				switch (level)
				{

				case 1 :
					j = Random.Range(0, 3);
					Instantiate(hazardchooselevel1(j), spawnPosition, spawnRotation);
					break;

				case 2 :
					j = Random.Range(0, 3);
					Instantiate(hazardchooselevel2(j), spawnPosition, spawnRotation);

					break;

				case 3 :
					j = Random.Range(0, 3);
					Instantiate(hazardchooselevel3(j), spawnPosition, spawnRotation);
					break;
				case 4 :
					j = Random.Range(0, 3);
					Instantiate(hazardchooselevel4(j), spawnPosition, spawnRotation);
					break; 
				case 5:
					j = Random.Range(0, 3);
					Instantiate(hazardchooselevel5(j), spawnPosition, spawnRotation);
					break;
				case 6:
					j = Random.Range(0, 3);
					Instantiate(hazardchooselevel6(j), spawnPosition, spawnRotation);
					break;   
				case 7:
					j = Random.Range(0, 3);
					Instantiate(hazardchooselevel7(j), spawnPosition, spawnRotation);
					break;  
				case 8:
					j = Random.Range(0, 3);
					Instantiate(hazardchooselevel8(j), spawnPosition, spawnRotation);
					break;
				case 9:
					j = Random.Range(0, 3);
					Instantiate(hazardchooselevel9(j), spawnPosition, spawnRotation);
					break; 
				case 10:
					j = Random.Range(0, 3);
					Instantiate(hazardchooselevel10(j), spawnPosition, spawnRotation);
					break; 






				}
				yield return new WaitForSeconds(spawnWait);
			}
			yield return new WaitForSeconds(waveWait);
		}
	}

	public void AddScore(int newScoreValue)
	{
		score =  score  + newScoreValue;
		Debug.Log("Score is "+score);
		UpdateScore ();

	}

	void UpdateScore()
	{


		if (inverse)
		{
			scoreText.GetComponent<Text>().color = Color.white;
		}
		else
		{
			scoreText.GetComponent<Text>().color = Color.black;
		}
		scoreText.text = "" + score;
		// scoreText.text = "";
		StartCoroutine(ExecuteAfterTime(1));

	}

	IEnumerator ExecuteAfterTime(float time)
	{

		yield return new WaitForSeconds(time);
		scoreText.text = "";
		// Code to execute after the delay
	}


	GameObject hazardchooselevel1(int i)
	{
		if( i == 0)
		{
			return level1hazard1;
		}
		else if (i == 1)
		{
			return level1hazard2;
		}

		else
		{
			return level1hazard3;
		}
	}


	GameObject hazardchooselevel2(int i)
	{
		if (i == 0)
		{
			return level2hazard1;
		}
		else if (i == 1)
		{
			return level2hazard2;
		}

		else
		{
			return level2hazard3;
		}
	}

	GameObject hazardchooselevel3(int i)
	{
		if (i == 0)
		{
			return level3hazard1;
		}
		else if (i == 1)
		{
			return level3hazard2;
		}

		else
		{
			return level3hazard3;
		}

	}

	GameObject hazardchooselevel4(int i)
	{
		if (i == 0)
		{
			return level4hazard1;
		}
		else if (i == 1)
		{
			return level4hazard2;
		}

		else
		{
			return level4hazard3;
		}

	}

	GameObject hazardchooselevel5(int i)
	{
		if (i == 0)
		{
			return level5hazard1;
		}
		else if (i == 1)
		{
			return level5hazard2;
		}

		else
		{
			return level5hazard3;
		}

	}


	GameObject hazardchooselevel6(int i)
	{
		if (i == 0)
		{
			return level6hazard1;
		}
		else if (i == 1)
		{
			return level6hazard2;
		}

		else
		{
			return level6hazard3;
		}

	}

	GameObject hazardchooselevel7(int i)
	{
		if (i == 0)
		{
			return level7hazard1;
		}
		else if (i == 1)
		{
			return level7hazard2;
		}

		else
		{
			return level7hazard3;
		}

	}

	GameObject hazardchooselevel8(int i)
	{
		if (i == 0)
		{
			return level8hazard1;
		}
		else if (i == 1)
		{
			return level8hazard2;
		}

		else
		{
			return level8hazard3;
		}

	}

	GameObject hazardchooselevel9(int i)
	{
		if (i == 0)
		{
			return level9hazard1;
		}
		else if (i == 1)
		{
			return level9hazard2;
		}

		else
		{
			return level9hazard3;
		}

	}
	GameObject hazardchooselevel10(int i)
	{
		if (i == 0)
		{
			return level10hazard1;
		}
		else if (i == 1)
		{
			return level10hazard2;
		}

		else
		{
			return level10hazard3;
		}

	}




}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour {

	public GameObject pausepanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void pause()
	{
		pausepanel.SetActive (true);
		//Time.timeScale = 0;
		StartCoroutine(ExecuteAfterTime(1));

	
	}

	public void resume()
	{
		
		Time.timeScale = 1;
		pausepanel.SetActive (false);
	}


	IEnumerator ExecuteAfterTime(float time)
	{

		yield return new WaitForSeconds(time);
		Time.timeScale = 0;
		// Code to execute after the delay
	}


	IEnumerator ExecuteAfterTime2(float time)
	{

		yield return new WaitForSeconds(time);

		// Code to execute after the delay
	}



}

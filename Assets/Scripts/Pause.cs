using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Pause : MonoBehaviour {

    public GameObject pausePanel, GameControllerObject;
	public bool Paused;
	// Use this for initialization
	void Start () {

		Paused = false;

        GameControllerObject = GameObject.FindGameObjectWithTag("GameController");


	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Escape))
			{
			Resume(true);
			}
		

	}

	public void Resume(bool state)
	{
		if (state) {
			pausePanel.SetActive (true);
            GameControllerObject.GetComponent<GameController>().gamepause = true;

			Time.timeScale = 0;

		} else {
			Time.timeScale = 1;
			GetComponent<Button> ().interactable = true;
            GameControllerObject.GetComponent<GameController>().gamepause = false;

			pausePanel.SetActive (false);
		}



	}

	public void LoadByIndex(int sceneIndex)
	{
		//SceneManager.UnloadScene ();

		SceneManager.LoadScene (sceneIndex,LoadSceneMode.Single);


	}


	public void Exit()
	{
		Application.Quit ();
	}



}
	
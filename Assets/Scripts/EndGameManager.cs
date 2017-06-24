using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour {

    public GameObject help1, help2, help3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1, LoadSceneMode.Single);
    }


    public void UnPause()
    {
        Time.timeScale = 1;
    }

    public void help2call()
    {
        
        help2.SetActive(true);

    }
    public void help3call()
    {

        help3.SetActive(true);

    }


}

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class loadstartscene : MonoBehaviour {
	//public GameObject loadingImage;

public Text highscore ;
	void Start()
	{
        highscore.text= "Highscore: " + PlayerPrefs.GetInt ("Highscore");
		Time.timeScale = 1;
	
	}

	public void  LoadByIndex(int sceneIndex)
	{

		if (sceneIndex < 0 || sceneIndex >= SceneManager.sceneCountInBuildSettings) {
			return;

		}
	

		LoadingScene.LoadScene(sceneIndex);
}

}
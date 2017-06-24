using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GLogin : MonoBehaviour {
    GPGDemo gpg = new GPGDemo();
	// Use this for initialization
	void Start () {
        gpg.LogIn();

        gpg.OnAddScoreToLeaderBorad(PlayerPrefs.GetInt("Highscore"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

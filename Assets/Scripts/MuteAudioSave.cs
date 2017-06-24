using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteAudioSave : MonoBehaviour {

    public GameObject Mute, Unmuted;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (PlayerPrefs.GetInt("mute", 0) == 0)
        {
			Mute.SetActive (false);
            Unmuted.SetActive(true);
            AudioListener.volume = 1;
        }
        else
        {
			Unmuted.SetActive (false);
            Mute.SetActive(true);
            AudioListener.volume = 0;
        }
		
	}

  public   void turnonmute()
    {
        PlayerPrefs.SetInt("mute", 1);
    }

  public void turnoffmute()
  {
      PlayerPrefs.SetInt("mute", 0);
  }


    






}

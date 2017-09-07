using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class GameplayMusic : MonoBehaviour {
    public AudioSource[] sound;

    bool flag1;

	// Use this for initialization
	void Start () {
        sound = GetComponents<AudioSource>();
        flag1 = true;
        if (flag1)
        {
            sound[0].Play();
        }
		
	}
	
	// Update is called once per frame
	void Update () {

        
        if (flag1 && !sound[0].isPlaying)
        {
            sound[1].Play();
            flag1 = false;
        }

		
	}
}

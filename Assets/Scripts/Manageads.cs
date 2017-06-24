using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manageads : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void showad()
    {
        AdManager.Instance.ShowBanner();
    }


    public void removead()
    {
        AdManager.Instance.hideBanner();
    }

    public void showvideoad()
    {
        AdManager.Instance.showVideo();
    }


}

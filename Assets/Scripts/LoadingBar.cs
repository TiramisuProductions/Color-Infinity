using System.Collections;
using UnityEngine.UI;

using UnityEngine;

public class LoadingBar : MonoBehaviour {
    public Transform Loadingbar;
    

	// Use this for initialization
	void Start () {
        
        
		
	}

   public  void nextcolor(Color color)
    {
        GetComponent<Image>().color = color;
        
    }
	
	// Update is called once per frame
	void Update () {
       
	}
}

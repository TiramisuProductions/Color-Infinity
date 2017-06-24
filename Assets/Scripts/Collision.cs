using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour {
    GameObject UpperBorderObject,GameControllerObject;
   public  Text Score;
   public  GameObject EndPanel;
   public GPGDemo gpg;
   public GameObject Pausebtn;
   private Manageads manageads;
   public GameObject gamemusic;

	// Use this for initialization
	void Start () {
        gpg = new GPGDemo();
        UpperBorderObject = GameObject.FindGameObjectWithTag("upborder");
        GameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        Pausebtn = GameObject.FindGameObjectWithTag("Pause");
       // gamemusic = GameObject.FindGameObjectWithTag("GameMusic");
      manageads   = new Manageads();
	}
	
	// Update is called once per frame
	void Update () {


		
	}



    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);

        if (UpperBorderObject.GetComponent<UpperBorder>().colorchange > 0.8)
        {
            if (other.tag.Trim().Equals(UpperBorderObject.GetComponent<UpperBorder>().colorshow().Trim()) && GameControllerObject.GetComponent<GameController>().inverse == false)
            {
                Time.timeScale = 0;
                EndPanel.SetActive(true);
                Pausebtn.SetActive(false);

                if (PlayerPrefs.GetInt("Highscore") < GameControllerObject.GetComponent<GameController>().score)
                {
                    PlayerPrefs.SetInt("Highscore", GameControllerObject.GetComponent<GameController>().score);
                    gpg.OnAddScoreToLeaderBorad(GameControllerObject.GetComponent<GameController>().score);
                }
				Score.text = "YOUR SCORE IS " + GameControllerObject.GetComponent<GameController>().score;
//                gamemusic.SetActive(false);
    //            GetComponent<AudioSource>().Play();
                StartCoroutine("ExecuteVideoAdAfterTime");
                manageads.showad();
				GameControllerObject.GetComponent<GameController> ().gameend = true;                


            }




            else if (!other.tag.Trim().Equals(UpperBorderObject.GetComponent<UpperBorder>().colorshow().Trim()) && GameControllerObject.GetComponent<GameController>().inverse == true)
            {
                Time.timeScale = 0;

                EndPanel.SetActive(true);
                Pausebtn.SetActive(false);
                if (PlayerPrefs.GetInt("Highscore") < GameControllerObject.GetComponent<GameController>().score)
                {
                    PlayerPrefs.SetInt("Highscore", GameControllerObject.GetComponent<GameController>().score);
                    gpg.OnAddScoreToLeaderBorad(GameControllerObject.GetComponent<GameController>().score);
                }
                Score.text = "YOUR SCORE IS " + GameControllerObject.GetComponent<GameController>().score;
       //         gamemusic.SetActive(false);
     //           GetComponent<AudioSource>().Play();
                StartCoroutine("ExecuteVideoAdAfterTime");
                manageads.showad();
				GameControllerObject.GetComponent<GameController> ().gameend = true;   
            }

           

        }
    }

    IEnumerator ExecuteVideoAdAfterTime()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        while (!AdManager.Instance.isvideoadready())
            yield return null;
        AdManager.Instance.showVideo();
        // Code to execute after the delay

    }


}

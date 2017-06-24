using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InverseMode : MonoBehaviour {
    public GameController gamecontroller;
  public   GameObject Quad;
  public GameObject Border;
  public GameObject Help1, Help2,Help3;
  
  public Text Inversetext;
  public bool run,run2;
  private int counter1;
//  public Texture inverse,noninverse;
	public Texture inverse, noninverse;
	// Use this for initialization
	void Start () {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        Border = GameObject.FindGameObjectWithTag("Border");
        run2 = true;
        run = true;
       
        if (gameControllerObject != null)
        {
            gamecontroller = gameControllerObject.GetComponent<GameController>();
        }
        counter1 = 0;
	}
	
	// Update is called once per frame
	void Update () {

       
            if (gamecontroller.inverse == true)
            {

                Inversetext.GetComponent<Text>().color = Color.white;
			GetComponent<Renderer> ().material.SetTexture("_MainTex",inverse);

                if (PlayerPrefs.GetInt("help2", 0) == 0)
                {
                    Time.timeScale = 0;
                    PlayerPrefs.SetInt("help2", 1);
                    Help2.SetActive(true);
                }
                if (run == true)
                {
                    Inversetext.text = "Inverse Mode ";
                    StartCoroutine(ExecuteAfterTime(2));
                    StartCoroutine(ExecuteAfterTime2(25));
                    run = false;
                }


                


            }



        

        else
        {
			GetComponent<Renderer>().material.SetTexture("_MainTex",noninverse);
            StartCoroutine(ExecuteAfterTime3(3));

           
			GetComponent<Renderer> ().material.SetTexture ("_MainTex",noninverse);
                }
                
            }
           

           

                
            
           
      


    IEnumerator ExecuteAfterTime(float time)
    {

        yield return new WaitForSeconds(time);
        Inversetext.text = "";
        // Code to execute after the delay
    }

    IEnumerator ExecuteAfterTime2(float time)
    {

        yield return new WaitForSeconds(time);
        run = true;
        // Code to execute after the delay
    }

    IEnumerator ExecuteAfterTime3(float time)
    {

        yield return new WaitForSeconds(time);
        if (PlayerPrefs.GetInt("help1", 0) == 0)
        {
            Time.timeScale = 0;
            PlayerPrefs.SetInt("help1", 1);
            Help1.SetActive(true);
        }
        // Code to execute after the delay
    }
}

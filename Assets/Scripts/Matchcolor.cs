using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Matchcolor : MonoBehaviour
{

    // Use this for initialization
    public int scoreValue;
    public GameController gamecontroller;
    public UpperBorder upborder;
    public LowerBorder lowborder;
    public GameObject EndPanel;
    public GPGDemo gpg;
    public Text Score;
    public GameObject Pausebtn;
    private Manageads manageads;
    public GameObject gamemusic;


    // Use this for initialization
    void Start()
    {
        gpg = new GPGDemo();
        manageads = new Manageads();
        Pausebtn = GameObject.FindGameObjectWithTag("Pause");
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        gamemusic = GameObject.FindGameObjectWithTag("GameMusic");
        if (gameControllerObject != null)
        {
            gamecontroller = gameControllerObject.GetComponent<GameController>();
        }

        GameObject upperborderObject = GameObject.FindGameObjectWithTag("upborder");
        if (upperborderObject != null)
        {
            //Debug.Log("Hello");
            upborder = upperborderObject.GetComponent<UpperBorder>();
        }
        GameObject lowerborderObject = GameObject.FindGameObjectWithTag("lowborder");
        if (upperborderObject != null)
        {
            Debug.Log("Hello");
            lowborder = lowerborderObject.GetComponent<LowerBorder>();
        }
    }

    // Update is called once per frame
    void Update()
    {


      //  Debug.Log("Bitch" + upborder.colorshow());
        //if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) 
        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            if (gamecontroller.gameend == false && gamecontroller.gamepause == false)
            {
                Debug.Log("Tapped"+ gamecontroller.GetComponent<GameController>().gameend.ToString());
                Ray ray;
                {
                    //Debug.Log("Touch detected.");

                    RaycastHit hit;
                    //Ray ray = Camera.main.ScreenPointToRay((Input.GetTouch(0).position));
                    if (Input.GetMouseButtonDown(0))
                    { ray = Camera.main.ScreenPointToRay((Input.mousePosition)); }
                    else
                    {
                        ray = Camera.main.ScreenPointToRay((Input.GetTouch(0).position));
                    }
                    if (Physics.Raycast(ray, out hit))
                    {
                        //Debug.Log("Raycast hit " + hit.collider.name);
                        Debug.Log("Raycast tag " + hit.collider.gameObject.tag);

                        if (hit.collider.gameObject.tag == "red"
                           || hit.collider.gameObject.tag == "orange"
                            || hit.collider.gameObject.tag == "yellow"
                            || hit.collider.gameObject.tag == "brown"
                           || hit.collider.gameObject.tag == "pink"
                            || hit.collider.gameObject.tag == "white"
                            || hit.collider.gameObject.tag == "green"
                            || hit.collider.gameObject.tag == "purple"

                            )
                        {
                            // Debug.Log("Color" + upborder.colorshow());
                            //Debug.Log("The tag matches.");
                            //Debug.Log(hit.collider.gameObject.GetComponent<Renderer>().material.color);
                            if (gamecontroller.inverse == false)
                            {
                                Debug.Log(hit.collider.gameObject.tag.Trim());

                                if (hit.collider.gameObject.tag.Trim().Equals(upborder.colorshow().Trim()))
                                {

                                    // Debug.Log("Color Match." + hit.collider.gameObject.tag+ " border :"+ upborder.colorshow());
                                    gamecontroller.AddScore(1);


                                }

                                else
                                {
                                    gamecontroller.GetComponent<GameController>().gameend = true;
                                    Time.timeScale = 0;
                                    EndPanel.SetActive(true);
                                    Pausebtn.SetActive(false);
                                   

                                    if (PlayerPrefs.GetInt("Highscore") < gamecontroller.GetComponent<GameController>().score)
                                    {
                                        PlayerPrefs.SetInt("Highscore", gamecontroller.GetComponent<GameController>().score);
                                        gpg.OnAddScoreToLeaderBorad(gamecontroller.GetComponent<GameController>().score);
                                    }
									Score.text = "YOUR SCORE IS " + gamecontroller.GetComponent<GameController>().score;
                                    gamemusic.SetActive(false);
                                    GetComponent<AudioSource>().Play();
									gamecontroller.gameend = true;
                                    StartCoroutine("ExecuteVideoAdAfterTime");
                                    manageads.showad();
                                    
                                }
                            }
                            else
                            {
                                if (!hit.collider.gameObject.tag.Trim().Equals(upborder.colorshow().Trim()))
                                {
                                    //  Debug.Log("Color MisMatch." + hit.collider.gameObject.tag + " border :" + upborder.colorshow());
                                    gamecontroller.AddScore(1);
                                    

                                }
                                else
                                {
                                    gamecontroller.GetComponent<GameController>().gameend = true;
                                    Time.timeScale = 0;
                                    
                                    EndPanel.SetActive(true);
                                    Pausebtn.SetActive(false);
                                    if (PlayerPrefs.GetInt("Highscore") < gamecontroller.GetComponent<GameController>().score)
                                    {
                                        PlayerPrefs.SetInt("Highscore", gamecontroller.GetComponent<GameController>().score);
                                        gpg.OnAddScoreToLeaderBorad(gamecontroller.GetComponent<GameController>().score);
                                    }
									Score.text = "YOUR SCORE IS " + gamecontroller.GetComponent<GameController>().score;
                                    gamemusic.SetActive(false);
                                    GetComponent<AudioSource>().Play();
                                    StartCoroutine("ExecuteVideoAdAfterTime");
                                    manageads.showad();
									gamecontroller.gameend = true;
                                }
                            }




                        }
                    }
                }
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



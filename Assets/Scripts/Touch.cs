using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour
{
    public GameObject explosion, GameControllerObject,DestroyAudio1,DestroyAudio2;
    

    // Use this for initialization
    void Start()
    {
        GameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        DestroyAudio1 = GameObject.FindGameObjectWithTag("DestroyAudio1");
        DestroyAudio2 = GameObject.FindGameObjectWithTag("DestroyAudio2");

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) )
        {
            if (GameControllerObject.GetComponent<GameController>().gameend == false && GameControllerObject.GetComponent<GameController>().gamepause == false)
            {

                Debug.Log("Tapped" + GameControllerObject.GetComponent<GameController>().gameend.ToString());
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
                    //	Debug.Log("Raycast hit " + hit.collider.name);
                    //	Debug.Log("Raycast tag " + hit.collider.gameObject.tag);	

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
                        Vector3 t = hit.collider.transform.position;
                        //Debug.Log("Color");
                        //  Debug.Log("The tag matches.");
                        Destroy(hit.collider.gameObject);
                        if (explosion != null)
                        {
                            explosion = (GameObject)Instantiate(explosion, t, Quaternion.identity);
                            int r = Random.Range(0, 2);
                            {
                                if (r == 0)
                                {
                                    DestroyAudio1.GetComponent<AudioSource>().Play();
                                }
                                else
                                {
                                    DestroyAudio2.GetComponent<AudioSource>().Play();
                                }
                            }
                        }
                        Destroy(explosion, 5);
                    }
                }
            }
        }
        }
    }
}

using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour
{
    public GameObject explosion, GameControllerObject,DestroyAudio1,DestroyAudio2;
    

    // Use this for initialization
    void Start()
    {
        //GameControllerObject = GameObject.FindGameObjectWithTag("GameController");
       // DestroyAudio1 = GameObject.FindGameObjectWithTag("DestroyAudio1");
        //DestroyAudio2 = GameObject.FindGameObjectWithTag("DestroyAudio2");
		gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color",Color.red);

    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log("foo",gameObject);

        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) )
        {

			Debug.Log ("Whatlol");
            

                
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

					Debug.Log("fuck"+hit.collider.gameObject.tag);
					Destroy (hit.transform.parent.gameObject);

                    
                        Vector3 t = hit.collider.transform.position;
                        //Debug.Log("Color");
                        //  Debug.Log("The tag matches.");
                        //Destroy(hit.collider.gameObject);
                           explosion = (GameObject)Instantiate(explosion, t, Quaternion.identity);                 
                        Destroy(explosion,1);
				
                    }
                }
            }
        }
        }
    


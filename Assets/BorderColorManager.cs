using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderColorManager : MonoBehaviour {

	public Color Brown = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	public Color Yellow = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	public Color Red = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	public Color Orange = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	public Color Pink = new Color (0.2F, 0.3F, 0.4F, 0.5F);
	public Color Purple = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	public Color White = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	public Color Green = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	public GameObject gamecontrollerobject;
	public Color tempcolor;
	public int counter;

	// Use this for initialization
	void Start () {
		gamecontrollerobject = GameObject.FindGameObjectWithTag ("gamecontroller");
		StaticShare.currentbordercolor = colorchooselevel1 ();
	
		counter = 0;
		gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color",StaticShare.currentbordercolor);

		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	public void colorchange()
	{
		StartCoroutine (Wait (0.5f));
		do {
			tempcolor = colorchooselevel1 ();
		} while (tempcolor == StaticShare.currentbordercolor);
			
		

		
		StaticShare.currentbordercolor = tempcolor;

		counter = 0;
		gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color",StaticShare.currentbordercolor);
	}


	IEnumerator Wait(float duration)
	{
		yield return new WaitForSeconds (duration);
		StopCoroutine (Wait (0.5f));
	}


	Color colorchooselevel1()
	{

		int j  = Random.Range (0, 3);

		switch (j) {

		case 0:
			return Green;
			break;
		case 1:
			return Brown;
			break;
		case 2:
			return Yellow;
			break;
		case 3:
			return Red;
			break;
		default:
			return Brown;
		}

	}
}

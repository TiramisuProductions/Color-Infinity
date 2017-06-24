using UnityEngine;
using System.Collections;

public class c : MonoBehaviour {
	public Renderer rnleft ;
	public Renderer rnright;
	public Renderer rntop;
	public string color;
	// Use this for initialization
	void Start () {
		InvokeRepeating("colorRandom", 0, 8.0f);
	}

	public 	string colorshow()
	{
		return color;
	}
	Color colorPicker(int i)
	{
		if (i ==1)
		{
			return Color.red;
			//color ="red";
		}
		if (i ==2)
		{
			return Color.yellow;
		}
		if (i ==3)
		{
			return Color.green;
		}
		
		if(i == 4)
		{
			return Color.magenta;
		}
		if(i == 5)
		{
			return Color.cyan;
		}
		return Color.blue;
	}
	void colorRandom()
	{
		int j = Random.Range (0, 5);
		
		Color color = colorPicker (j);
		
		

		
		rnleft.material.color = rnright.material.color= rntop.material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

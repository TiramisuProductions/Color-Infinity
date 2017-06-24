using UnityEngine;
using System.Collections;

public class LowerBorder : MonoBehaviour {
	// Use this for initialization
	public Renderer rnleft ;
	public Renderer rnright;
	public Renderer rnbottom;
	public string color;
	public Color Brown = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	public Color Yellow = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	public Color Red = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	public Color Orange = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	public Color Pink = new Color();
	// Use this for initialization
	void Start () {
		//InvokeRepeating("colorRandom", 0, 10.0f);
	}
	
	public 	string colorshow()
	{
		return color;
	}
	Color colorPicker(int i)
	{
		if (i ==1)
		{
			
			color ="red";
			return Color.red;
			
			
			
		}
		if (i ==2)
		{
			
			color ="brown";
			return Brown;
		}
		if (i ==3)
		{
			
			color ="yellow";
			return Yellow ;
		}
		
		if(i == 4)
		{
			
			color ="orange";
			return Orange;
		}
		
		
		color ="pink";
		return Pink;
	}
	void colorRandom()
	{
		int j = Random.Range (0, 5);
		
		Color color = colorPicker (j);
		
		
		
		
		rnleft.material.color = rnright.material.color= rnbottom.material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
}





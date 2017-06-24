using UnityEngine;
using System.Collections;

public class RandomPosition : MonoBehaviour {

	// Use this for initialization
	public float xmin,xmax;
	public int zmin,zmax;

	void Start () {
		float xpos = Random.Range(xmin,xmax);
		float zpos = Random.Range(zmin,zmax);
		transform.position = new Vector3(xpos, -15, zpos);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnCollisionEnter2D(Collision2D coll) 
	{
		if(GameObject.FindGameObjectWithTag("wall"))
		Destroy (gameObject);
		print ("wall");



	}
}

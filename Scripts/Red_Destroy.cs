using UnityEngine;
using System.Collections;


public class Red_Destroy : MonoBehaviour {

	//public string level;
	//public static bool redDead=true;
	public int pointsToDead;
	//public float yaxis1;
	//public bool axis=false;
	//public int pointsToAdd;
	//public int bonus;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver(){
		
		
		if (Input.GetMouseButtonDown (0)) {
				Destroy (gameObject);
				Lives.HurtPlayer (pointsToDead);
			print("Red_Destroy");
		}
	
	}

}

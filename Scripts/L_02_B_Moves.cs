using UnityEngine;
using System.Collections;

public class L_02_B_Moves : MonoBehaviour {

	public Rigidbody2D myRigi;
	public float downSpeed;

	// Use this for initialization
	void Start () {
		myRigi=GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		myRigi.velocity = new Vector2 ( myRigi.velocity.x,downSpeed);
	
	}
	void OnMouseOver(){
		
		
		if (Input.GetMouseButtonDown (0)) {
			Destroy (gameObject);
			//ScoreManeger.AddPoints (pointsToAdd);
			
		}
	}
}

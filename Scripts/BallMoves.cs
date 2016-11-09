using UnityEngine;
using System.Collections;

public class BallMoves : MonoBehaviour {
	private Rigidbody2D myRigi;


	public float xaxis;
	//public float xaxis1;
	public float yaxis;
	//public float yaxis1;
	public bool axis=false;
	public int pointsToAdd;
	public int pointsToDead;
	public int sc;


	public bool scor=false;

	public static bool deadOn= true;



	// Use this for initialization
	void Start () {
		sc = ScoreManeger.score;
	//	int[] randomLevels = new int[] {-5,-4,-3,-2,2,3,4,5,};

		myRigi = GetComponent<Rigidbody2D> ();
		//xaxis =randomLevels[Random.Range(0, randomLevels.Length)];
		//xaxis1 = Mathf.Abs (Random.Range (2,5));
	//	yaxis =randomLevels[Random.Range(0, randomLevels.Length)];

		//yaxis1 = Mathf.Abs (Random.Range (-5,-2));
	//	if(sc<=4){
		myRigi.velocity = new Vector2(Random.Range (-5,5),Random.Range (-5,5)).normalized*Clon.timespend;

		//}else if(sc<=40){
			
		//	myRigi.velocity = new Vector2(Random.Range (-5,5),Random.Range (-5,5)).normalized*Clon.timespend;
	//	}


		}

	void Update(){

		float x;
		float y;
		
	
			transform.Rotate(Vector3.forward*Time.deltaTime*(Random.Range(55,325)));
			transform.localScale += new Vector3(0.12F*Time.deltaTime,0.12F*Time.deltaTime, 0);
	
		//	transform.localPosition = new Vector3 (+);
		


	

		}

	void OnMouseOver(){


		if (Input.GetMouseButtonDown (0)) {
			if (GameObject.FindGameObjectWithTag ("player")) {
				Destroy (gameObject);
				ScoreManeger.AddPoints (pointsToAdd);
			} 
		}
}
}

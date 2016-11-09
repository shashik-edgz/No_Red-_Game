using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lives : MonoBehaviour {

	public static int live=3;
	public int deadCost;
	public bool dead;
	public string gameover;
	public int playerHealth;

	public GameObject heart1; 
	public GameObject heart2; 
	public GameObject heart3; 
	public bool heart;

	//public static int pointsToDead;

	Text text;
	public int myLive;


	// Use this for initialization
	void Start () {

		text = GetComponent<Text> ();
		live=myLive;
	
	}
	
	// Update is called once per frame
	void Update () {
	//	dead = BallMoves.deadOn;
		//live = playerHealth;
		text.text = "" + live;

		//

		if (live == 3) {
			heart1.SetActive (true);
			heart2.SetActive (true);
			heart3.SetActive (true);
		}
		if (live == 2) {
			heart3.SetActive (false);


		}
		if (live == 1) {
			heart2.SetActive (false);
		
		}
		

		if (live == 0) {
			Application.LoadLevel (gameover);
		}

	
	}

	public static void HurtPlayer(int pointsToDead)
	{
		live -= pointsToDead;
	}
}

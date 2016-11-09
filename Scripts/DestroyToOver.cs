using UnityEngine;
using System.Collections;

public class DestroyToOver : MonoBehaviour {
	public string leveltoload;
	public static bool contactDead=true;
	public int pointsToDead;
	//public int bonus;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnCollisionEnter2D(Collision2D coll) 
	{
		Destroy(GameObject.FindGameObjectWithTag ("player"));
		if (GameObject.FindGameObjectWithTag ("player"))
			Lives.HurtPlayer(pointsToDead);


	//	Application.LoadLevel (leveltoload);
	}
	//void OnTriggerStay2D(Collider2D other) {
		
		//if (GameObject.FindGameObjectWithTag ("red"))
			//ScoreManeger.AddPoints (bonus);


	//}

	

}

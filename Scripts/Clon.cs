using UnityEngine;
using System.Collections;

public class Clon : MonoBehaviour {
	public bool spwanTime = false;
	
	public GameObject red;
	public GameObject blue;
	public GameObject pink;
	public GameObject green;
	public GameObject yellow;
	private int randompick;
	private GameObject circul;

	public static bool anea=false;
	public static bool anea1=false;
	public static bool anea2=false;
	public static bool anea3=false;

	public Transform spwanT;
	public float time = 0;
	public float timespeed;
	public float waitTime;
	public float YelidTime;
	public float scorey=5;
	public static float godtime = 10;
	public static float timespend;
	public int sc;
	public float t;
	//public Renderer rend;
	//public float spwanYelid;
	
	//public float timeSpwan;
	
	// Use this for initialization
	void Start () {
		
		//if (ScoreManeger.score == 0)


			timespend = 3;
		
			

		
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		timespeed += Time.deltaTime;
		
		if (!spwanTime) {
			time += Time.deltaTime;
		}
		
		if (time >= waitTime/timespeed) {
			spwan();
		}

		if (ScoreManeger.score > scorey) {
			scorey += 5;

			timespend += 1;
		}
		if (ScoreManeger.score > godtime) {
			godtime+=10;
		}
		if (ScoreManeger.score >=20) {
			timeS (anea);

		} 
		if(ScoreManeger.score>=40){
			timeS1 (anea1);
		}
		if(ScoreManeger.score>=60){
			timeS2 (anea2);
		}
		t = timespend;

	}
	void timeS(bool t){
		if (!t) {
			timespend = 3;
			anea = true;
		}

	}
	void timeS1(bool t){
		if (!t) {
			timespend = 3;
			anea1 = true;
		}
	}
	void timeS2(bool t){
		if (!t) {
			timespend = 3;
			anea2 = true;
		}
	}
	
	void spwan()
	{
		spwanTime = true;
		time = 0;
		randompick = Mathf.Abs (Random.Range (1, 6));
		if (randompick == 1) {
			circul = red;
		}
		if (randompick == 2) {
			circul = blue;
		}
		if (randompick == 3) {
			circul = green;
		}
		if (randompick == 4) {
			circul = pink;
		}
		if (randompick == 5) {
			circul = yellow;
		}
		
		Instantiate (circul, spwanT.position, spwanT.rotation);
		
		StartCoroutine(QuestAsync());
		
		
		
		
	}
	
	IEnumerator QuestAsync(){
		
		
		//if (timespeed > timeSpwan) {
		//	spwanTime = true;
		//	timespeed = 0;
		//	timeSpwan += 2;
		//	yield return new WaitForSeconds (spwanYelid);
		//	spwanTime = false;
			
		//} else {
			yield return new WaitForSeconds (YelidTime);
			spwanTime = false;
		//}
	}


}

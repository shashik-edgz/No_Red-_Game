using UnityEngine;
using System.Collections;

public class Cloning : MonoBehaviour {
	public bool spwanTime = false;

	public GameObject red;
	public GameObject blue;
	//public GameObject pink;
	public GameObject green;
//	public GameObject yellow;
	private int randompick;
	private GameObject circul;


	public Transform spwanT;
	public float time = 0;
	public float timespeed;
	public float waitTime;
	public float YelidTime;
	public float spwanYelid;

	public float timeSpwan;

	// Use this for initialization
	void Start () {



	
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
	
	}

	 void spwan()
	{
		spwanTime = true;
		time = 0;
		randompick = Mathf.Abs (Random.Range (1, 4));
		if (randompick == 1) {
			circul = red;
		}
		if (randompick == 2) {
			circul = blue;
		}
		if (randompick == 3) {
			circul = green;
		}
	//	if (randompick == 4) {
	//		circul = pink;
		//}
	//	if (randompick == 5) {
	//		circul = yellow;
		//}

		Instantiate (circul, spwanT.position, spwanT.rotation);

		StartCoroutine(QuestAsync());




	}

	IEnumerator QuestAsync(){


		if (timespeed > timeSpwan) {
			spwanTime = true;
			timespeed = 0;
			timeSpwan += 2;
			yield return new WaitForSeconds (spwanYelid);
			spwanTime = false;

		} else {
			yield return new WaitForSeconds (YelidTime);
			spwanTime = false;
		}
	}




}

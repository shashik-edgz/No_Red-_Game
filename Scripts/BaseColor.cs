using UnityEngine;
using System.Collections;

public class BaseColor : MonoBehaviour {
	public bool spwanTime = false;
	
	public Color red = Color.red;
	public Color blue=Color.blue;
	//public Color pink=Color.magenta;
	public Color green=Color.green;
	//public Color yellow=Color.yellow;
	public static int randompick;
	private  Color circul;
	public string levelover;
	
	
	//public Transform spwanT;
	public float time = 0;
	public float timespeed;
	public float waitTime;
	public float YelidTime;
	public float timeSpwan;
	public  int pre;


	public Renderer base1;
	//public Renderer base2;
	//public Renderer base3;
	
	// Use this for initialization
	void Start () {
		base1 = GetComponent<Renderer>();



		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		timespeed += Time.deltaTime;
		
		if (!spwanTime) {
			time += Time.deltaTime;
		}

		
		if (time >= waitTime) {
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
			pre = 1;


		}
		if (randompick == 2) {
			circul = blue;
			pre =2;
		}
		if (randompick == 3) {
			circul = green;
			pre =3;
		}
		//if (randompick == 4) {
			//circul = pink;
			//print ("4");
		//}
		//if (randompick == 5) {
			//circul = yellow;
			//print ("5");
		//}



		base1.material.color = circul;
		
		StartCoroutine(QuestAsync());

		
		
	}
	
	IEnumerator QuestAsync(){
		if (timespeed > timeSpwan) {
			spwanTime = true;
			timespeed = 0;
			timeSpwan += 1;
			yield return new WaitForSeconds (timeSpwan);
			spwanTime = false;
		} else {
			yield return new WaitForSeconds (timeSpwan);
			spwanTime = false;
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		


		if (!other.gameObject.CompareTag ("rathu") && (pre == 1)) {
			Destroy (other.gameObject);
			Application.LoadLevel (levelover);
		
		}
		if (!other.gameObject.CompareTag ("nil")&& (pre == 2)) {
			Destroy (other.gameObject);
			Application.LoadLevel (levelover);

		}
		if (!other.gameObject.CompareTag ("kola")&& (pre == 3)) {
			Destroy (other.gameObject);
			Application.LoadLevel (levelover);

		}
		
	}

}

using UnityEngine;
using System.Collections;

public class GodMode : MonoBehaviour {

	public GameObject wall;
	public GameObject popText;
	public GameObject overText;

	public float godScore;
	public int nowScore;
	public float godTime;





	// Use this for initialization
	void Start () {
	//
	
	}
	
	// Update is called once per frame
	void Update () {
		nowScore = ScoreManeger.score;
		godScore=Clon.godtime;

		if (nowScore > 10)
		{
			print("open pop and god Script");
			pop ();
		god ();
	}


	
	}

	void pop()
	{
		popText.SetActive (true);
		StartCoroutine(waitToClose());


	}

	void god()
	{
		wall.SetActive (false);
		StartCoroutine(godOver());

	}

	IEnumerator waitToClose()
	{
		yield return new WaitForSeconds (2);
		popText.SetActive (false);
	}
	IEnumerator godOver()
	{
		yield return new WaitForSeconds (godTime);
		overText.SetActive (true);

		StartCoroutine(overT());
	}
	IEnumerator overT()
	{
		yield return new WaitForSeconds (2);
		overText.SetActive (false);
		wall.SetActive (true);


	}


}

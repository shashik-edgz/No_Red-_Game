using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreManeger : MonoBehaviour {
	Text text;
	public static int score;



	void Start()
	{
		text = GetComponent<Text> ();
		score = 0;
	}

	void Update()
	{
		if (score < 0)
			score = 0;
		text.text = "" + score;


	
	}

	public static void AddPoints(int pointsToAdd)
	{
		score += pointsToAdd;
	}
	public static void Reset()
	{

		score=0;
	
	}

}

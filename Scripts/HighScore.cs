using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
	Text text;

	public static int pscore;
	public static int Hscore;

	
	void Start()

	{
		text = GetComponent<Text> ();
		Hscore = PlayerPrefs.GetInt ("HighScore");
		pscore = ScoreManeger.score;

	
	}
	
	void Update()
	{
		if (pscore > Hscore) {
			Hscore = pscore;
		}
		text.text = "" + Hscore;
		PlayerPrefs.SetInt ("HighScore", Hscore);
		
	}


}

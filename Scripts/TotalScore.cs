using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour {

	public static int cScore;
	public static int sScore;
	public static int pScore;


	Text sText;

	// Use this for initialization
	void Start () {
	 	
		sText = GetComponent<Text> ();
		pScore = ScoreManeger.score;
		sScore = PlayerPrefs.GetInt ("TotalScore");
		pScore = pScore+sScore;
		sText.text = "" + pScore;
		PlayerPrefs.SetInt ("TotalScore", pScore);


	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	

}

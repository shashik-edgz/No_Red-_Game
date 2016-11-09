using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OverScore : MonoBehaviour {
	public int overScore;
	Text scText;
	// Use this for initialization
	void Start () {
		scText = GetComponent<Text> ();
		overScore = ScoreManeger.score;
		scText.text = "" + overScore;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

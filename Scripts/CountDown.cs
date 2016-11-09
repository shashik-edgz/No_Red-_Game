using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {
	public float start = 3;

	public Text textCount;

	// Use this for initialization
	void Start () {
		textCount = GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		start -= Time.realtimeSinceStartup;
		textCount.text = "" + start;
	
	}
}

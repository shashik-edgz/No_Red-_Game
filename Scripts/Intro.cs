using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {

	public GameObject intro;
	public bool show=true;
	// Use this for initialization
	void Start () {

		//show = PlayerPrefs.GetInt("show") > 0;

	
	}
	
	// Update is called once per frame
	void Update () {
		intro.SetActive (show);

		if (show)
		Time.timeScale = 0;

		
		if (!show)
			Time.timeScale = 1;

	}


}

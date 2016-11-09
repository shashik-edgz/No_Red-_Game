using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class Intro_2 : MonoBehaviour {


	public GameObject dont;

	void Start (){

	}

	 void Update(){

			Time.timeScale=0;

	}

	public void btn(){
		Time.timeScale=1;	
		dont.SetActive (false);

	
	}


}

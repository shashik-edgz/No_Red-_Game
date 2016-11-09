using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class popUp : MonoBehaviour {
	public GameObject popUpWindow;
	public static bool pop;
	public float timego;
	public string level;
	//public static float pTime=Time.timeScale;
	//public static float poTime=1f;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	public void Update () {

		//	popUpWindow.SetActive (true);

		

		//if (timego < 6) {
			
		//	pop = true;
		//} else {
		//	pop = false;
		//}
	
	}
	public void Resume()
	{
	
		popUpWindow.SetActive (false);
		Time.timeScale=1f;


	}

	public void Pause()

	{
		popUpWindow.SetActive (true);
		Time.timeScale = 0f;
	}
	 public void Home()
	{
		Application.LoadLevel (level);
		Time.timeScale=1f;
	}
	

	

}

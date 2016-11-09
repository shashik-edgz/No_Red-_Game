using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class Play : MonoBehaviour {
	public string levels;
	public string playLevel;
	public string about1;
	private BannerView bannerView;
	AudioSource audio;
	// Use this for initialization
	void Start () {
		//bannerView.Hide ();
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	//	bannerView.Hide ();
	}

	public void gamePLay()
	{
		Application.LoadLevel (levels);
	}

	public void gameStart()
	{
		Application.LoadLevel (playLevel);
	}
	public void about()
	{
		Application.LoadLevel (about1);

	}

	public void quit()
	{
		Application.Quit ();
		print ("quit");
	}


}

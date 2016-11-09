using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using GoogleMobileAds.Api;
using GoogleMobileAds;


public class OverCircle : MonoBehaviour {
	private Transform circle;
	private Rigidbody2D myRigi;
	public float xpos=-239;
	public float ypos=-2;
	public float minscale=-90;
	public float maxscale=90;


	// Use this for initialization
	void Start () {
		//ShowAd ();
	//	ShowInterstitial();
		//bannerView.Hide ();
		myRigi = GetComponent<Rigidbody2D>();


	
	}
	
	// Update is called once per frame
	void Update () {
	   
		myRigi.transform.localPosition = new Vector2 (xpos,ypos);
	
		myRigi.transform.localScale = new Vector2 (Random.Range (minscale, maxscale),transform.localScale.y);

	}
	/*  public void ShowAd()
	{
		if (Advertisement.IsReady())
		{
			Advertisement.Show();
		}
	} */






}

using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
public class Slow_Ads : MonoBehaviour {

	public float timy;
	public int temp;
	public float ppTime;

	// Use this for initialization
	void Start () {
		//Time.timeScale = 0f;


		//ShowRewardedAd();
	}
	
	// Update is called once per frame
	public void Update () {
		reward ();

	}
 public void ShowRewardedAd()
		{
		Debug.Log ("Th12131321321313132own.");
			if (Advertisement.IsReady("rewardedVideoZone"))
			{
				var options = new ShowOptions { resultCallback = HandleShowResult };
				Advertisement.Show("rewardedVideoZone", options);
			}
		}

		private void HandleShowResult(ShowResult result)
		{
			switch (result)
			
		{
		case ShowResult.Finished:
			Debug.Log ("The ad was successfully shown.");
				reward ();
				break;
			case ShowResult.Skipped:
				Debug.Log("The ad was skipped before reaching the end.");
				break;
			case ShowResult.Failed:
				Debug.LogError("The ad failed to be shown.");
				break;
			}
		}

	public void reward()
	{
		Debug.Log ("Shit Work.");
		timy += 1 * Time.deltaTime;
		temp = (int)timy;

		Time.timeScale = 0.6f;
		if (temp >=10f)
			Time.timeScale = 1f;
	}



}


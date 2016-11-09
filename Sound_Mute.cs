using UnityEngine;
using System.Collections;

public class Sound_Mute : MonoBehaviour {

	public AudioSource audio;
	public GameObject mute;
	public GameObject non_mute;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	/*	if (Input.GetKeyDown (KeyCode.Mouse0))
		if (audio.mute)
		{
			audio.mute = false;
			non_mute.SetActive(true);
			mute.SetActive(false);

		} else {
			audio.mute = true;
			mute.SetActive(true);
			non_mute.SetActive(false);

		}*/
	}

	void toggle(bool desi)
	{
		audio.mute = desi;
		mute.SetActive (desi);
		non_mute.SetActive (!desi);
	}
}

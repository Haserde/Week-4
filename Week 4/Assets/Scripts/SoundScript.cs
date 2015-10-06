using UnityEngine;
using System.Collections;

public class SoundScript : MonoBehaviour {

	//use variables for multiple uses e.g getComponent
	private AudioSource lasershot;

	// Use this for initialization
	void Start () {
		lasershot = gameObject.GetComponent<AudioSource> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.G) && lasershot.isPlaying == false) {
			lasershot.Play ();
		}
	
	}
}

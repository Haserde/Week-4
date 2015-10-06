using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {

	private AudioSource loop;

	void Start(){
		loop = gameObject.GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player")
		{
			GetComponent<AudioSource>().Play();
		}
		else {
			GetComponent<AudioSource>().Stop ();
		}
	}
}
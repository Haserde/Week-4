using UnityEngine;
using System.Collections;

public class PlayOrder : MonoBehaviour {

	public AudioClip fall_whistle;
	public AudioClip pop;

	void Start()
	{
		StartCoroutine(play_fall_whistle());
	}
	
	IEnumerator play_fall_whistle()
	{
		GetComponent<AudioSource>().clip = fall_whistle;
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
		GetComponent<AudioSource>().clip = pop;
		GetComponent<AudioSource>().Play();
	}
}



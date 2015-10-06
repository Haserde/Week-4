using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour {

	public float shakeAmount = 5f;
	public float shakeTime = 1.5f;
	
	bool isShaking = false;
	private Vector3 originalLocation;
	
	// Update is called once per frame
	void OnTriggerEnter (Collider otherObject) {
			StartCoroutine ("shakeScreen"); 
			Debug.Log ("collision hit");
}
	void Update(){
		if (isShaking) {
			transform.position = originalLocation + Random.insideUnitSphere * shakeAmount * Time.deltaTime;
		}
	}
	IEnumerator shakeScreen() {
		isShaking = true;
		originalLocation = transform.position;
		yield return new WaitForSeconds (shakeTime);
		isShaking = false;
	}
}
using UnityEngine;
using System.Collections;

public class explosionScript : MonoBehaviour {

	public GameObject explosion;
	public GameObject loopSpawn;

	void start(){
		Destroy (gameObject, gameObject.GetComponent<ParticleSystem> ().duration);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			Instantiate (explosion, transform.position, transform.rotation);
			Destroy(gameObject);
			Instantiate (loopSpawn, transform.position, transform.rotation);

		}
	}
}		
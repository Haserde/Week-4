using UnityEngine;
using System.Collections;

public class MeshChange : MonoBehaviour {

	public GameObject building1;
	public GameObject building2;

	public GameObject building1alt;
	public GameObject building2alt;


	Mesh initialMesh;
	Mesh swapMesh;
	
	GameObject theTarget;
	
	// Use this for initialization
	void Start () {
		
		theTarget = building1;
		
		initialMesh = building1.GetComponent<MeshFilter>().mesh;
		swapMesh = building1alt.GetComponent<MeshFilter>().mesh;

	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "qStart"){
			theTarget.GetComponent<MeshFilter>().mesh = swapMesh;
		}
	}
}
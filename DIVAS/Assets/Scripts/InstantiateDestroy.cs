using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateDestroy : MonoBehaviour {

	public GameObject fallingObject;
	public float lifetime; 

	// Use this for initialization
	void Start () {
		InvokeRepeating ("fallObject", 2f, 2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void fallObject (){
		Vector3 randomposition = new Vector3 (Random.Range (-10f, 10f), 20, Random.Range (-10f, 10f)); 
		var cloneFallingObject = Instantiate (fallingObject, randomposition, Quaternion.identity);
		Destroy (cloneFallingObject, lifetime);
	}
}

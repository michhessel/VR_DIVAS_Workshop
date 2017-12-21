using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goWhereyouGaze : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			transform.position += this.transform.forward * speed * Time.deltaTime;
		}
	}
}

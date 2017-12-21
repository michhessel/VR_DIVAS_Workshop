using System;
using System.Collections;
using UnityEngine;
using VRStandardAssets.Common;
using VRStandardAssets.Utils;

public class moveToHere : MonoBehaviour

{
	//make a variable that is set to the camera. 
	public Transform player; 
	public Transform Target; 
	private VRInteractiveItem myInteractiveItem;                    

	private void Awake()
	{
		myInteractiveItem = GetComponent<VRInteractiveItem>();


	}

	private void OnEnable ()
	{
		myInteractiveItem.OnClick += PointerClick;
	}

	private void OnDisable ()
	{
		myInteractiveItem.OnClick -= PointerClick;
	}


	private void PointerClick(){
		//call functions to be called on pointer click here
		player.transform.position = Target.transform.position; 
		//player.transform.position = new Vector3 (0,0,0);
		Debug.Log ("click");
	}

}

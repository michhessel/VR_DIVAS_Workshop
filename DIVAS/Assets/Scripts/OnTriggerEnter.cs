using System;
using System.Collections;
using UnityEngine;
using VRStandardAssets.Common;
using VRStandardAssets.Utils;

public class OnTriggerEnter : MonoBehaviour {

	private VRInteractiveItem myInteractiveItem;
	public GameObject hiddenObject;



	private void Awake()
	{
		myInteractiveItem = GetComponent<VRInteractiveItem>();
	}


	//when this script is enabled, bind the "interactiveItem" event to the function below called HandleDown
	private void OnEnable ()
	{
		myInteractiveItem.OnOver += PointerEnter;
		myInteractiveItem.OnOut += PointerExit;
	}

	//when this script is disabled, unbindbind the "interactiveItem" event to the function below called HandleDown
	private void OnDisable ()
	{
		myInteractiveItem.OnOver -= PointerEnter;
		myInteractiveItem.OnOut -= PointerExit;
	}

	public void PointerEnter()
	{
		GetComponent<Renderer> ().material.color = Color.green;
//		hiddenObject.SetActive (true);
	}


	public void PointerExit()
	{
		GetComponent<Renderer> ().material.color = Color.white;
//		hiddenObject.SetActive (false);
	}
}
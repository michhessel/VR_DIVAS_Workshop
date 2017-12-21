using System;
using System.Collections;
using UnityEngine;
using VRStandardAssets.Common;
using VRStandardAssets.Utils;

public class PlayAudioOnClick : MonoBehaviour

{

	public AudioClip clickSound;              

	private VRInteractiveItem myInteractiveItem;                    
	private AudioSource myAudio;                                    

	private void Awake()
	{
		// Setup the references.
		myAudio = GetComponent<AudioSource> ();
		myInteractiveItem = GetComponent<VRInteractiveItem>();

	}

	//when this script is enabled, bind the "interactiveItem" event to the function below called HandleDown
	private void OnEnable ()
	{
		myInteractiveItem.OnDown += HandleDown;
	}

	//when this script is disabled, unbindbind the "interactiveItem" event to the function below called HandleDown
	private void OnDisable ()
	{
		myInteractiveItem.OnUp -= HandleDown;
	}

	private void HandleDown()
	{
		myAudio.clip = clickSound;
		myAudio.Play();
	}
}

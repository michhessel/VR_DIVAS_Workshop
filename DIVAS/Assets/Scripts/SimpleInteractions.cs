using System;
using System.Collections;
using UnityEngine;
using VRStandardAssets.Common;
using VRStandardAssets.Utils;

public class SimpleInteractions : MonoBehaviour

{

	private VRInteractiveItem myInteractiveItem;                    

	private void Awake()
	{
		myInteractiveItem = GetComponent<VRInteractiveItem>();


	}

	private void OnEnable ()
	{
		myInteractiveItem.OnOver += PointerEnter;
		myInteractiveItem.OnOut += PointerExit;
		myInteractiveItem.OnClick += PointerClick;
		myInteractiveItem.OnDoubleClick += PointerDoubleClick;
		myInteractiveItem.OnUp += ClickUp;
		myInteractiveItem.OnDown += ClickDown;


	}

	private void OnDisable ()
	{
		myInteractiveItem.OnOver -= PointerEnter;
		myInteractiveItem.OnOut -= PointerExit;
		myInteractiveItem.OnClick -= PointerClick;
		myInteractiveItem.OnDoubleClick -= PointerDoubleClick;
		myInteractiveItem.OnUp -= ClickUp;
		myInteractiveItem.OnDown -= ClickDown;
	}

	private void PointerEnter()
	{
		//call functions to be called on pointer enter here
	}
	private void PointerExit()
	{
		//call functions to be called on pointer exit here
	}
	private void PointerClick()
	{
		//call functions to be called on pointer click here
	}
	private void PointerDoubleClick()
	{
		//call functions to be called on pointer doubleclick here
	}
	private void ClickUp()
	{
		//call functions to be called on pointer click up here
	}
	private void ClickDown()
	{
		//call functions to be called on pointer click down here
	}
}

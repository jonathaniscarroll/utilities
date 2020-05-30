using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseClickEvents : MonoBehaviour {
	
	public int mouseButton;
	public UnityEvent eventOnMouseButton;
	public UnityEvent eventOnMouseButtonDown;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(mouseButton)){
			eventOnMouseButtonDown.Invoke();
		}
		if(Input.GetMouseButton(mouseButton)){
			eventOnMouseButton.Invoke();
		}
	}
}

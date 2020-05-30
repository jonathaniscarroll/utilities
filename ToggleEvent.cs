﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ToggleEvent : MonoBehaviour
{
	[SerializeField]
	private bool state;
	public bool State{
		get;
		set;
	}
	
	public UnityEvent trueEvent;
	public UnityEvent falseEvent;
	
	public void Toggle(){
		
		State = !State;
		
		CheckState();
	}
	
	public void CheckState(){
		if(State){
			trueEvent.Invoke();
		} else {
			falseEvent.Invoke();
		}
	}
		
		
}

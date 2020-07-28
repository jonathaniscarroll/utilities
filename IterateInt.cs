﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IterateInt : MonoBehaviour
{
	[SerializeField]
	private int _current;
	public int Current{
		get{
			return _current;
		}
		set{
			//intEvent.Invoke(value);
			_current = value;
		}
	}
	
	public IntEvent intEvent;
	
	public void Iterate(){
		intEvent.Invoke(Current);
		Current++;
	}
}

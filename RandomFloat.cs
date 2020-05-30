﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFloat : MonoBehaviour
{
	[MinMaxSlider(0,1000)]
	public Vector2 range;
	public FloatEvent outputFloat;
	public void Generate(){
		float output = Random.Range(range.x,range.y);
		outputFloat.Invoke(output);
	}
	
}

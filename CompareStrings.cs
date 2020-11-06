﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareStrings : MonoBehaviour
{
	public StringReference String1;
	public StringReference String2;
	public BoolEvent ComparisonResult;
	public void Compare(){
		bool result = String1.Value==String2.Value;
		ComparisonResult.Invoke(result);
	}
}

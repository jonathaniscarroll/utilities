using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringToFloat : MonoBehaviour
{
	public StringReference StringReference;
	
	public FloatEvent OutputFloat;
	
	public void Output(){
		float output = float.Parse(StringReference.Value);
		OutputFloat.Invoke(output);
	}
}

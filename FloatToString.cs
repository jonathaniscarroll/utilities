using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloatToString : MonoBehaviour
{
	public StringEvent stringEvent;
	public string prepend;
	public string append;
	public void FloatInput(float input){
		string str = prepend + input.ToString() + append;
		stringEvent.Invoke(str);
	}
}

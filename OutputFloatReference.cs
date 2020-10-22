using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputFloatReference : MonoBehaviour
{
	public FloatReference FloatReference;
	public FloatEvent OutputFloat;
	public void Output(){
		OutputFloat.Invoke(FloatReference.Value);
	}
}

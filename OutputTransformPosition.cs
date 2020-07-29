using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputTransformPosition : MonoBehaviour
{
	public Transform transformToOutput;
	public Vector3Event vector3Event;
	public void Output(){
		vector3Event.Invoke(transformToOutput.position);
		Debug.Log("transform event ",gameObject);
	}
}

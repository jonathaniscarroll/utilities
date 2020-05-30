using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SetPosition : MonoBehaviour
{
	public Transform TargetTransform;
	public Vector3 Offset;
	public UnityEvent OnMove;
	
	public void InputVector3(Vector3 input){
		TargetTransform.transform.position = input + Offset;
		OnMove.Invoke();
	}
}

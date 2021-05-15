using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SetPosition : MonoBehaviour
{
	public Transform TargetTransform{
		get {return _targetTransform;}
		set{_targetTransform = value;}
	}
	[SerializeField]
	private Transform _targetTransform;
	public Vector3 Offset;
	public UnityEvent OnMove;
	public bool LocalPosition;
	
	public void InputVector3(Vector3 input){
		if(LocalPosition){
			TargetTransform.transform.localPosition = input + Offset;
		} else {
			TargetTransform.transform.position = input + Offset;	
		}
		OnMove.Invoke();
	}
}

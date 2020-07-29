﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceInDirection : MonoBehaviour
{
	public FloatReference Force;
	public Vector3Reference Direction;
	[SerializeField]
	private Rigidbody _targetRigidbody;
	public Rigidbody TargetRigidbody{
		get{
			return _targetRigidbody;
		} set{
			_targetRigidbody = value;
		}
	}
	
	
	public void OutputForce(){
		TargetRigidbody.AddForce(Direction.Value * Force.Value);
	}
}

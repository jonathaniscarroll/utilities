using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Game Object Function/Toggle Rigidbody")]
public class ToggleRigidbodyGravity : GameObjectFunction
{
	public bool stateToSet;
	public override void TriggerFunction(GameObject gameObject){
		Rigidbody rigidBody;
		if(rigidBody=gameObject.GetComponent<Rigidbody>()){
			rigidBody.useGravity = stateToSet;
			rigidBody.isKinematic = !stateToSet;
		}
		Animator animator;
		if(animator = gameObject.GetComponent<Animator>()){
			animator.enabled = !stateToSet;
		}
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Game Object Function/Add Force")]
public class AddForceToObject : GameObjectFunction
{
	public float forceToAdd;
	public override void TriggerFunction(GameObject gameObject){
		Rigidbody rigidbody;
		Transform target = gameObject.transform.parent;
		if(target==null){
			target=gameObject.transform;
		}
		if(rigidbody=gameObject.GetComponent<Rigidbody>()){
			rigidbody.AddForce((target.transform.position - gameObject.transform.position).normalized * forceToAdd * Time.smoothDeltaTime);
		}
	}
}

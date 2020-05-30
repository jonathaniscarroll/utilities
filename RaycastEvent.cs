using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RaycastEvent : MonoBehaviour
{
	public UnityEvent onRaycasted;
	
	public void SendRaycast(){
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast (ray, out hit))
		{
			if(hit.collider.GetComponent<RaycastEvent>())
			{
				hit.collider.GetComponent<RaycastEvent>().onRaycasted.Invoke();
				Debug.Log("hit " + name);
				//onRaycasted.Invoke();
			}
		}
	}
}

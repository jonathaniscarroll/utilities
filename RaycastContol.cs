using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RaycastContol : MonoBehaviour
{
	public RaycastEvent onRaycasted;
	
	[System.Serializable]
	public class RaycastEvent{
		public GameObjectEvent GameObjectEvent;
		public Vector3Event PositionEvent;
		//public LayerMask LayerMask;
	}
	
	public void SendRaycast(){
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast (ray, out hit))
		{
			RaycastContol raycast;
			if(raycast=hit.collider.GetComponent<RaycastContol>())
			{
				raycast.onRaycasted.GameObjectEvent.Invoke(hit.collider.gameObject);
				raycast.onRaycasted.PositionEvent.Invoke(hit.point);
				
				Debug.Log("hit " + name);
				//onRaycasted.Invoke();
			}
		}
	}
}

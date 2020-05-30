using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputRaycastEvent : MonoBehaviour
{
	[System.Serializable]
	public class RaycastEvent{
		public GameObjectEvent GameObjectEvent;
		public Vector3Event PositionEvent;
		public LayerMask LayerMask;
	}
	
	public List<RaycastEvent> RaycastEvents;
	
	public void OutputRaycast(){
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		foreach(RaycastEvent rEvent in RaycastEvents){
			
			if (Physics.Raycast(ray, out hit, Mathf.Infinity,rEvent.LayerMask))
			{
				Debug.Log(hit.collider.gameObject);	
				//if(hit.collider.gameObject==gameObject){
					rEvent.PositionEvent.Invoke(hit.point);	
					rEvent.GameObjectEvent.Invoke(hit.collider.gameObject);
					
				//}
				
			}
		}
	}
	
}

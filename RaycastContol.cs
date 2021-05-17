using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class RaycastContol : MonoBehaviour
{
	public Transform TransformToRaycastFrom;
	public Camera CameraToRaycastFrom;
	public RaycastEvent onRaycasted;
	public Vector3Event OutputRaycastPoint;
	
	[System.Serializable]
	public class RaycastEvent{
		public GameObjectEvent GameObjectEvent;
		public Vector3Event PositionEvent;
		public GameObjectVector3Event GameObjectPositionEvent;
		//public LayerMask LayerMask;
	}
	
	public void SendRaycast(){
		
		if(EventSystem.current.IsPointerOverGameObject()){
			Debug.Log("sending RC hit UI");
			return;
		}
		RaycastHit hit;
		//Physics.Raycast (cam.position, cam.forward, hit, 500)
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(TransformToRaycastFrom!=null){
			ray = new Ray(TransformToRaycastFrom.position, TransformToRaycastFrom.forward);
		}
		if(CameraToRaycastFrom!=null){
			ray = CameraToRaycastFrom.ScreenPointToRay(Input.mousePosition);
		}
		
		if(Physics.Raycast (ray, out hit))
		{
			Debug.Log("sending RC hit " + hit.transform.gameObject,hit.transform.gameObject);
			RaycastContol raycast;
			if(raycast=hit.collider.GetComponent<RaycastContol>())
			{
				raycast.onRaycasted.GameObjectEvent.Invoke(hit.collider.gameObject);
				raycast.onRaycasted.PositionEvent.Invoke(hit.point);
				raycast.onRaycasted.GameObjectPositionEvent.Invoke(hit.collider.gameObject,hit.point);
				OutputRaycastPoint.Invoke(hit.point);
				//Debug.Log("hit " + name,hit.collider.gameObject);
				//onRaycasted.Invoke();
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LifeCycleTriggerEvents : MonoBehaviour
{
	[System.Serializable]
	public class TriggerEvent{
		public TriggerTime trigger;
		public UnityEvent eventToTrigger;
	}
	public enum TriggerTime {Start,Awake,Disable,Update};
	public List<TriggerEvent> triggerEvents;
	
	void Start(){
		foreach(TriggerEvent te in triggerEvents){
			if(te.trigger==TriggerTime.Start){
				te.eventToTrigger.Invoke();
			}	
		}
	}
	
	void Awake(){
		foreach(TriggerEvent te in triggerEvents){
			if(te.trigger==TriggerTime.Awake){
				te.eventToTrigger.Invoke();
			}	
		}
	}
	void Update(){
		foreach(TriggerEvent te in triggerEvents){
			if(te.trigger==TriggerTime.Update){
				te.eventToTrigger.Invoke();
			}	
		}
	}
}

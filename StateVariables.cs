using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class StateVariables : MonoBehaviour
{
	[System.Serializable]
	public class StateFloat{
		public string Name;
		public float Value{
			get{
				return _value;
			}
			set{
				_value = value;
				OutputFloat.Invoke(_value);
			}
		}
		[SerializeField]
		private float _value;
		public FloatEvent OutputFloat;
	}
	
	public List<StateFloat> StateFloats;
	
	public void Increment(string key, float value){
		StateFloats.FirstOrDefault(i => i.Name == key).Value+=value;
	}
	public float GetFloat(string key){
		Debug.Log("looking for " + key);
		return StateFloats.FirstOrDefault(i => i.Name == key).Value;
	}
}

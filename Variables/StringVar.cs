using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/String")]
public class StringVar : ScriptableObject
{
	[SerializeField]
	private string _value;
	public string Value{
		get{return _value;}
		set{
			_value = value;
			OnChange.Invoke(_value);
		}
	}
	
	public StringEvent OnChange;
	
}

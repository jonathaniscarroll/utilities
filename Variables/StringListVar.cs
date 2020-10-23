using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/StringList")]
public class StringListVar : ScriptableObject
{
	[SerializeField]
	private List<string> _value;
	public List<string> Value{
		get{
			return _value;
		} set{
			_value = value;
		}
	}
	
	public StringListGameEvent StringListEvent;
	
	public void Add(string input){
		Value.Add(input);
	}
	
}

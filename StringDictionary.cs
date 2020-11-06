using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class StringDictionary : ScriptableObject
{
	public Dictionary<string,string> Dictionary{get{return _dictionary;}set{_dictionary= value;Debug.Log(_dictionary.Keys.Count);}}
	private Dictionary<string,string> _dictionary;
}

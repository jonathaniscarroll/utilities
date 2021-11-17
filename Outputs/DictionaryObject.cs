using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryObject : MonoBehaviour
{
	[SerializeField]
	private Dictionary<string,string> dictionary;
	public Dictionary<string,string> Dictionary{
		get{
			return dictionary;
		}
		set{
			dictionary = value;
			OutputData.Invoke(dictionary);
		}
	}
	public StringStringDictionaryEvent OutputData;
}

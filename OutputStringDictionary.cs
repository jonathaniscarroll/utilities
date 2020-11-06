using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputStringDictionary : MonoBehaviour
{
	public Dictionary<string,string> DictionaryToOutput{
		get;
		set;
	}
	
	public StringStringDictionaryEvent DictionaryEvent;
	
	public void Output(){
		DictionaryEvent.Invoke(DictionaryToOutput);
	}
}

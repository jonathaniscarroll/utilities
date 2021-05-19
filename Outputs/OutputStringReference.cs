using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputStringReference : MonoBehaviour
{
	public StringReference StringReference;
	public StringEvent OutputString;
	public void Output(){
		OutputString.Invoke(StringReference.Value);
	}
}

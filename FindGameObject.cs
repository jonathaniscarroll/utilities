using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGameObject : MonoBehaviour
{
	public GameObjectEvent OutputGameObject;
	public void InputString(string input){
		
		GameObject output = GameObject.Find(input);
		if(output!=null){
			Debug.Log("found " + input);
			OutputGameObject.Invoke(output);	
		}
		
	}
}

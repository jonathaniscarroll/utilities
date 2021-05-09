using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGameObjectByTag : MonoBehaviour
{
	public GameObjectEvent OutputGameObject;
	public void InputTag(string input){
		GameObject output = GameObject.FindGameObjectWithTag(input);
		OutputGameObject.Invoke(output);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputGameObjectListReference : MonoBehaviour
{
	public GameObjectListReference GameObjectListToOutput;
	//{
	//	get{
	//		return _gameObjectListToOutput;
	//	}
	//	set{
	//		_gameObjectListToOutput = value;
	//	}
	//}
	//[SerializeField]
	//private List<GameObject> _gameObjectListToOutput;
	
	public GameObjectListEvent GameObjectListEvent;
	public GameObjectEvent GameObjectEvent;
	
	public void Output(){
		GameObjectListEvent.Invoke(GameObjectListToOutput.Value);
	}
	public void Set(List<GameObject> input){
		GameObjectListToOutput.Value = input;
	}
	
	//public 
}

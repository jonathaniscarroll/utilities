using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfGameObjects : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> gameObjectList;
	public List<GameObject> GameObjectList{
		get{
			return gameObjectList;
		}
		set{
			gameObjectList = value;
		}
	}
	
	public GameObjectListEvent gameObjectListEvent;
	public void OutputList(){
		gameObjectListEvent.Invoke(GameObjectList);
	}
}

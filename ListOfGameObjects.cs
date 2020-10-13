using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

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
	public void CountList(){
		OutputCount.Invoke(GameObjectList.Count);
	}
	
	public GameObjectEvent IteratedGameObject;
	public UnityEvent OnIterationComplete;
	public IntEvent OutputCount;
	
	
	public void IterateList(int iterator){
		if(iterator<GameObjectList.Count){
			Debug.Log(GameObjectList[iterator].name + " " + iterator) ;
			IteratedGameObject.Invoke(GameObjectList[iterator]);
		} else {
			OnIterationComplete.Invoke();
		}
			
	}
}

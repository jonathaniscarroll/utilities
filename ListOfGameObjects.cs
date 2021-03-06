﻿using System.Collections;
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
	public int AmountToRandomlyOutput;
	
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
	
	public void IterateAllObects(){
		foreach(GameObject obj in GameObjectList){
			IteratedGameObject.Invoke(obj);
		}
		OnIterationComplete.Invoke();
	}
	
	public void CreateListFromTag(string tag){
		GameObjectList = new List<GameObject>(GameObject.FindGameObjectsWithTag(tag));
	}
	
	public void IterateRandomObjects(){
		List<GameObject> output = new List<GameObject>();
		float random = Random.Range(0,AmountToRandomlyOutput);
		Debug.Log("random " +random);
		for (int i = 0; i < random; i++)
		{
			output.Add(GameObjectList[Random.Range(0,GameObjectList.Count)]);
                 
		}
		gameObjectListEvent.Invoke(output);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameObjectPool : MonoBehaviour
{
	public bool InstantiateObjects = false;
	public List<GameObject> Pool;
	public GameObjectEvent OutputPooledObject;
	
	public void InputGameObject(GameObject input){
		GameObject output;
		if(Pool==null){
			Pool = new List<GameObject>();
		}
		if(output = Pool.FirstOrDefault(i => GameObject.ReferenceEquals(i,input))){
			//object already in pool
		} else{
			if(InstantiateObjects){
				output = Instantiate(input);
			} else{
				output = input;
			}
			Pool.Add(output);
		}
		OutputPooledObject.Invoke(output);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubicleObjectUI : ObjectUI<CubicleObject>
{
	
	public void InputGameObject(GameObject input){
		CubicleObject output = null;
		if(output = input.GetComponent<CubicleObject>()){
			Output.Invoke(output);
		}
	}
	
	
	//public void Generate(CubicleObject input){
	//	CubicleObjectUI output = Instantiate(Prefab,Parent);
		
	//}
}

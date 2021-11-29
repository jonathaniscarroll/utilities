using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubicleObjectUI : ObjectUI<CubicleObject>
{
	
	public void InputGameObject(GameObject input){
		CubicleObject output = null;
		if(output = input.GetComponent<CubicleObject>()){
			ThisObject = output;
		}
	}
	public SpriteEvent OutputSpriteEvent;
	public void OutputSprite(){
		Sprite output = ThisObject.SpriteRenderer.sprite;
		OutputSpriteEvent.Invoke(output);
	}
	public StringEvent OutputNameEvent;
	public void OutputName(){
		string output = ThisObject.Name;
		OutputNameEvent.Invoke(output);
	}
	public IntEvent OutputValueEvent;
	public void OutputValue(){
		OutputValueEvent.Invoke(ThisObject.Value);
	}
}

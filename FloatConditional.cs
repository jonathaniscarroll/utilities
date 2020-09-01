using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatConditional : MonoBehaviour
{
	public enum Condition {Greater,Lesser,Equal,GreaterEqual,LesserEqual};
	public Condition condition;
	public FloatReference ConditionFloat;
	public BoolEvent ConditionEvent;
	public void InputFloat(FloatVar Input){
		bool output = false;
		switch (condition)
		{
		case Condition.Greater:
			output = Input.Value > ConditionFloat;
			break;
		case Condition.Lesser:
			output = Input.Value < ConditionFloat;
			break;
		case Condition.GreaterEqual:
			output = Input.Value >= ConditionFloat;
			break;
		case Condition.LesserEqual:
			output = Input.Value <= ConditionFloat;
			break;
		case Condition.Equal:
			output = Input.Value == ConditionFloat;
			break;
		}
		ConditionEvent.Invoke(output);
	}
}

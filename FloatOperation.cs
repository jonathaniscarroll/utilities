using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatOperation : MonoBehaviour
{
	public enum Operation {plus,minus,divide,multiply,percentage}; 
	public Operation operation;
	public FloatReference OperatorFloat;
	public FloatEvent OutputFloat;
	public void InputFloat(FloatVar input){
		float output = 0;
		switch (operation)
		{
		case Operation.plus:
			output = input.Value + OperatorFloat.Value;
			break;
		case Operation.minus:
			output = input.Value - OperatorFloat.Value;
			break;
		case Operation.divide:
			output = input.Value / OperatorFloat.Value;
			break;
		case Operation.multiply:
			output = input.Value * OperatorFloat.Value;
			break;
		case Operation.percentage:
			output = input.Value % OperatorFloat.Value;
			break;
		}
		OutputFloat.Invoke(output);
	}
	
}

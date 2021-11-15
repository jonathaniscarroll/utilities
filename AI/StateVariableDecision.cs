using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Decisions/StateVariableDecision")]
public class StateVariableDecision : Decision
{
	public string StateToCheck;
	public float Threshold;
	public enum Compare {
		Greater,Lesser
	};
	public Compare compare;
	public override bool Decide(StateController controller){
		bool outcome = false;
		switch (compare){
		case Compare.Greater:
			outcome = controller.StateVariables.GetInt(StateToCheck) > Threshold;
			break;
		case Compare.Lesser:
			outcome = controller.StateVariables.GetInt(StateToCheck) < Threshold;
			break;
		}
		//Debug.Log("worked" + outcome);
		return outcome;
	}
}

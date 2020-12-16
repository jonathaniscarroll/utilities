using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Decisions/CheckTarget")]
public class CheckTargetDecision : Decision
{
	public string TargetName;
	public override bool Decide(StateController controller){
		bool outcome;
		outcome = controller.TargetTransform.name == TargetName;
		return outcome;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Decisions/MinimumDistance")]
public class DistanceDecision : Decision
{
    public float minimumDistance = 0;

    public override bool Decide(StateController controller)
    {
        bool isLessThan = Compare(controller);
        return isLessThan;
    }

    private bool Compare(StateController controller)
	{
		if(controller.TargetTransform==null){
			return false;
		}
		float Distance = Vector3.Distance(controller.transform.position, controller.TargetTransform.position);
		
		if ( Distance<= minimumDistance)
        {
            return true;

        }
            return false;

    }
}

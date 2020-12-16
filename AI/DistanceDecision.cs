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
		//Debug.Log("distance " + Vector3.Distance(controller.navMeshAgent.transform.position, controller.navMeshAgent.destination) + " " + controller.navMeshAgent.destination);
		if(controller.navMeshAgent.destination==null){
			return false;
		}
	    if (Vector3.Distance(controller.navMeshAgent.transform.position, controller.navMeshAgent.destination) < minimumDistance)
        {

            //controller.hasASowTarget = false;
            return true;

        }
            return false;

    }
}

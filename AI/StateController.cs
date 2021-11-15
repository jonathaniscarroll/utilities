using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour
{
    public State currentState;
    public State remainState;
	//public NavMeshAgent navMeshAgent;
	public StateVariables StateVariables;

	public UserController userController;

	//public Vector3 TargetPosition{
	//	get;
	//	set;
	//}
	public Transform TargetTransform{
		get{return targetTransform;}
		set{targetTransform = value;
			OnTargetChanged.Invoke(targetTransform);
		}
	}
	[SerializeField]
	private Transform targetTransform;
	public TransformEvent OnTargetChanged;

    // Update is called once per frame
	public void UpdateState()
    {
        currentState.UpdateState(this);
    }
    void OnDrawGizmos()
    {
        if (currentState != null)
        {
            Gizmos.color = currentState.sceneGizmoColor;
            Gizmos.DrawWireSphere(transform.position,1f);
        }
    }
    public void TransitionToState(State nextState)
    {
        if (nextState != remainState)
        {
            currentState = nextState;
        }
    }

}

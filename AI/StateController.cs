using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour
{
    public State currentState;
    public State remainState;
	public NavMeshAgent navMeshAgent;
	public StateVariables StateVariables;

	public UserController userController;

	public Vector3 TargetPosition{
		get;
		set;
	}
	public Transform TargetTransform{
		get;
		set;
	}

    // Update is called once per frame
    void Update()
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

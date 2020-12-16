using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="AI/State")]
public class State : ScriptableObject
{
    public Action[] actions;
    public Transition[] transitions;
	public Color sceneGizmoColor = Color.grey;
	public bool RepeatAction;

    public void UpdateState(StateController controller)
	{
        //Debug.Log("state " + this.name);
        DoAction(controller);
        CheckTransition(controller);
    }
    private void DoAction(StateController controller)
    {
        for(int i = 0; i < actions.Length; i++)
        {
            //Debug.Log(actions[i]);
            actions[i].Act(controller);
        }
    }

    private void CheckTransition(StateController controller)
    {
        for(int i = 0; i < transitions.Length; i++)
        {
            bool decisionSucceeded = transitions[i].decision.Decide(controller);
            if (decisionSucceeded)
            {
                controller.TransitionToState(transitions[i].trueState);
            }
            else
            {
                controller.TransitionToState(transitions[i].falseState);
            }
        }
    }
}

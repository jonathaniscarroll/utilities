using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Actions/EventAction")]
public class EventAction : Action
{
    public string nameOfEvent;
    public override void Act(StateController controller)
    {
        DoEvent(controller);
    }

    private void DoEvent(StateController controller)
    {
	    controller.userController.InputMessage(nameOfEvent);
    }

}

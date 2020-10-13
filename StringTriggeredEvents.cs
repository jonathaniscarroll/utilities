using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class StringTriggeredEvents : MonoBehaviour
{
	[System.Serializable]
	public class StringCommand{
		public string CommandName;
		public StringEvent Command;
	}
	
	public List<StringCommand> StringCommands;
	
	public void InputCommand(string commandName){
		StringCommand command = StringCommands.FirstOrDefault(i => i.CommandName == commandName);
		command.Command.Invoke(commandName);
	}
}

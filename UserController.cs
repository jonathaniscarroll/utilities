using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Linq;

public class UserController : MonoBehaviour
{
	[System.Serializable]
	public class UserCommand{
		public string CommandName;
		public StringEvent Command;
	}
	public string UserName{
		get{return _user;}
		set{
			_user = value;
			OutputName.Invoke(_user);
		}
	}
	
	[SerializeField]
	private string _user;

	public string Message{
		get{return _message;}
		set{
			_message = value;
			InputMessage(_message);
		}
	}
	[SerializeField]
	private string _message;
	
	public void InputMessage(string message){
		
		string argument = "";
		UserCommand command = null;
		foreach(UserCommand cmd in UserCommands){
			if(message.Contains(cmd.CommandName)){
				command = cmd;
				Debug.Log("contains " + message);
				string[] str = message.Split(char.Parse(" "));
				if(str.Length>1){
					
					argument = str[1];	
				}
				
			}
		}
		if(command == null){
			//do message
			OutputMessage.Invoke(message);
			
		} else {
			//do command
			//Debug.Log("function " + command.CommandName + " argument " + argument);
			command.Command.Invoke(argument);
		}
		
	}
	
	public StringEvent OutputName;
	public StringEvent OutputMessage;
	public List<UserCommand> UserCommands;
}

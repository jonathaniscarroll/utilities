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
	
	public string UserID{
		get{return _userID;}
		set{
			_userID = value;
			OutputUserID.Invoke(_userID);
		}
	}
	
	[SerializeField]
	private string _userID;

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
				
				string[] str = message.Split(char.Parse(" "));
				//Debug.Log("contains " + message + " LEN " + str.Length);
				//if(str.Length==2){
				//	for(int i = 1;i<str.Length;i++){
				//		argument += str[i];	
				//	}
				//}
				//else {
					for(int i = 1;i<str.Length-1;i++){
						argument += str[i] + " ";	
					}
					argument += str[str.Length-1];
				//}
			}
		}
		if(command == null){
			//do message
			OutputMessage.Invoke(message);
			
		} else {
			//do command
			//Debug.Log("function " + command.CommandName + " argument " + argument);
			command.Command.Invoke(argument);
			OutputCommand.Invoke(command.CommandName+ " " +argument);
		}
		
	}
	
	public StringEvent OutputName;
	public StringEvent OutputUserID;
	public StringEvent OutputMessage;
	public StringEvent OutputCommand;
	public List<UserCommand> UserCommands;
}

using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;
using System.Collections;


public class PlayerManager : NetworkManager {

	public class MyMsgTypes {
		public static short MSG_CHARACTER_CLASS_ASSIGNMENT = 1000;
	};

	public class ClassAssignmentMessage : MessageBase {
		public PlayerCanvas.CharacterClass charClass;
	}

	public int[] playerConnectionIds = new int[(int)PlayerCanvas.CharacterClass.MAX];
		
	public void OnClassAssignment(NetworkMessage netMsg)
	{
		ClassAssignmentMessage msg = netMsg.ReadMessage<ClassAssignmentMessage>();
		Debug.Log("OnClassAssignment " + msg.charClass);
	}

	public override void OnStartClient(NetworkClient client) {
		client.RegisterHandler(MyMsgTypes.MSG_CHARACTER_CLASS_ASSIGNMENT, OnClassAssignment);
		Debug.Log ("Client " + client.connection.connectionId + " Started");
	}

	public override void OnServerConnect(NetworkConnection conn)
	{
		var connectionId = conn.connectionId;
		Debug.Log("Client " + connectionId + " Connected");
		AssignClass (connectionId);
	}

	void AssignClass(int connectionId) {
		for (int i=0; i<(int)PlayerCanvas.CharacterClass.MAX; ++i) {
			if (playerConnectionIds[i] == connectionId) {
				return;
			}
		}
		for (int i=0; i<(int)PlayerCanvas.CharacterClass.MAX; ++i) {
			if (playerConnectionIds[i] == -1) {
				playerConnectionIds[i] = connectionId;
				ClassAssignmentMessage msg = new ClassAssignmentMessage ();
				msg.charClass = (PlayerCanvas.CharacterClass)i;
				NetworkServer.SendToClient(connectionId, MyMsgTypes.MSG_CHARACTER_CLASS_ASSIGNMENT, msg);
				break;
			}
		}
	}



}

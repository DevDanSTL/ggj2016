using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;
using System.Collections;


public class TestPlayerManager : NetworkManager {

	public bool[] classUnavailable = new bool[(int)PlayerCanvas.CharacterClass.MAX];
	public int[] playerConnectionIds = new int[(int)PlayerCanvas.CharacterClass.MAX];
	 
	public override void OnStartServer ()
	{
		base.OnStartServer ();
		Debug.Log("Server started");

	}
		
	public class MyMsgTypes {
		public static short MSG_CHARACTER_CLASS_ASSIGNMENT = 1000;
	};

	public class ClassAssignmentMessage : MessageBase {
		public PlayerCanvas.CharacterClass charClass;
	}

	public void OnClassAssignment(NetworkMessage netMsg)
	{
		ClassAssignmentMessage msg = netMsg.ReadMessage<ClassAssignmentMessage>();
		Debug.Log("OnClassAssignment " + msg.charClass);
		TestPlayerUI.SetTargetClass (msg.charClass);
	}

	public override void OnStartClient(NetworkClient client) {
		client.RegisterHandler(MyMsgTypes.MSG_CHARACTER_CLASS_ASSIGNMENT, OnClassAssignment);
		Debug.Log ("Client " + client.connection.connectionId + " Started");
		AssignClass (client.connection.connectionId);
	}

	public override void OnServerConnect(NetworkConnection conn)
	{
		var connectionId = conn.connectionId;
		Debug.Log("Client " + connectionId + " Connected");
	}

	void AssignClass(int connectionId) {
		Debug.Log ("AssignClass");
		for (int i=0; i<(int)PlayerCanvas.CharacterClass.MAX; ++i) {
			if (playerConnectionIds[i] == connectionId) {
				return;
			}
		}
		Debug.Log ("Unassigned");
		for (int i=0; i<(int)PlayerCanvas.CharacterClass.MAX; ++i) {
			if (playerConnectionIds[i] == -1) {
				Debug.Log ("Assigning " + i);
				playerConnectionIds[i] = connectionId;
				ClassAssignmentMessage msg = new ClassAssignmentMessage ();
				msg.charClass = (PlayerCanvas.CharacterClass)i;
				NetworkServer.SendToClient(connectionId, MyMsgTypes.MSG_CHARACTER_CLASS_ASSIGNMENT, msg);
				Debug.Log ("Sent assignment msg");
				break;
			}
		}
	}

}

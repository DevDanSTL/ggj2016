using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;
using System.Collections;


public class TestPlayerManager : NetworkManager {

	public GameObject[] playerPrefabs = new GameObject[(int)PlayerCanvas.CharacterClass.MAX];
	public bool[] classUnavailable = new bool[(int)PlayerCanvas.CharacterClass.MAX];

	public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
	{
		base.OnServerAddPlayer(conn, playerControllerId);
		GameObject g = CreateAvailableClassPrefab ();
		NetworkServer.AddPlayerForConnection(conn, g, playerControllerId);

		var connectionId = conn.connectionId;
		Debug.Log("Client " + connectionId + " Connected");
	}

	GameObject CreateAvailableClassPrefab() {
		for (int i=0; i<(int)PlayerCanvas.CharacterClass.MAX; ++i) {
			if (classUnavailable [i] == false) {
				classUnavailable [i] = true;
				return Instantiate(this.playerPrefabs[i]);
			}
		}
		Debug.Log ("No classes available");
		return null;
	}



}

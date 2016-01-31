using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class TestBoss : NetworkBehaviour {

	static public TestBoss Instance;

	[SyncVar]
	public int hp = 500;

	void Awake () {
		Instance = this;
	}

	public void TakeDamage(int amount) {
		hp -= amount;
	}
}

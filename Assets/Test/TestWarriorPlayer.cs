using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class TestWarriorPlayer : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		if (this.isLocalPlayer == false) {
			Destroy (this);
		}
	}
}

using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlayerCanvas: NetworkBehaviour {

	public enum CharacterClass {
		Warrior,
		Mage,
		Cleric,
		Thief,
		MAX
	}

	public GameObject[] classPanels = new GameObject[(int)CharacterClass.MAX];

	public void SetPanelForPlayer(int playerNum) {
		for (int i = 0; i < (int)CharacterClass.MAX; i++) {
			var classPanel = classPanels[i];
			classPanel.SetActive(playerNum == i);
		}
	}

	void Awake() {

	}

	void Start() {
		SetPanelForPlayer(Random.Range(0,(int)CharacterClass.MAX));
	}
}

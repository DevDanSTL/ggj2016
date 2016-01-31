using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class TestPlayerUI : MonoBehaviour {

	static PlayerCanvas.CharacterClass targetClass;
	public GameObject[] classPanels = new GameObject[(int)PlayerCanvas.CharacterClass.MAX];

	// Use this for initialization
	public void Awake() {
		ActivateClassPanel (targetClass);
	}
		
	public void ActivateClassPanel(PlayerCanvas.CharacterClass charClass) {
		for (int i = 0; i < (int)PlayerCanvas.CharacterClass.MAX; i++) {
			var classPanel = classPanels[i];
			classPanel.SetActive((int)charClass == i);
		}
	}

	static public void SetTargetClass(PlayerCanvas.CharacterClass charClass) {
		targetClass = charClass;
	}
}

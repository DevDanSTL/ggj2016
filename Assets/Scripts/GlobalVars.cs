using UnityEngine;
using System.Collections;




public class GlobalVars : MonoBehaviour {

// Team Vars
public bool Rended = false;
public bool Taunted = false;
public bool Frozen = false;
public bool Burning = false;
public bool Empowered = false;
public bool Invisible = false;

// Mage Vars
public int MageHP = 100;
public int MageAtk = 5;
public bool MShielded = false;

// Thief Vars
public int ThiefHP = 75;

// Cleric Vars
public int ClericHP = 100;

// Warrior Vars
public int WarriorHP = 200;
public int WarriorAtk = 20;
public float OppMod = 1.5f;
public bool OppAtk = false;
public bool PShielded = false;

	// Use this for initialization
	void Start () {

       
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;
using BehaviorDesigner.Runtime;

public class GlobalVars : MonoBehaviour {

public BehaviorTree behaviorTree;

// Static Vars
public int BurnDamage = 5;
public float BurnTime = 2f;
public float FreezeMod = 1.5f;
static public int endVar = 0;

// Boss Vars
static public SharedInt BossHP;
public int BossAtk = 20;
public int BossHAtk = 40;
public int BossMAtk = 30;
public int BossSAtk = 50;
public int BossDef = 5;
// public var BossTarget = null; - Using Aggro for now
static public bool Rended = false;
static public bool Taunted = false;
static public bool Frozen = false;
static public bool Burning = false;

// Team Vars
public bool Empowered = false;
public bool Invisible = false;

// Mage Vars
static public SharedInt MageHP;
public int MageAtk = 5;
public int MageAggro = 0;
public bool MShielded = false;
static public float MageCooldown = 5f;

// Thief Vars
public int ThiefHP = 75;
public int ThiefAggro = 0;

// Cleric Vars
public int ClericHP = 100;
public int ClericAggro = 0;

// Warrior Vars
static public SharedInt WarriorHP;
static public int WarriorAtk = 15;
static public float WarriorCooldown = 3.3f;
static public int OppMod = 2;
static public int WAttack = 5;
static public SharedInt OppAtk;
static public SharedInt PShielded;
public int WarriorAggro = 0;

	// Use this for initialization
	void Start () {
      BossHP = (SharedInt)behaviorTree.GetVariable("BossHP");
      BossHP.Value = 500;
      WarriorHP = (SharedInt)GlobalVariables.Instance.GetVariable("WarriorHP");
      WarriorHP.Value = 200;
      MageHP = (SharedInt)GlobalVariables.Instance.GetVariable("MageHP");
      MageHP.Value = 100;
      OppAtk = (SharedInt)behaviorTree.GetVariable("OppAtk");
      OppAtk.Value = 0;
      PShielded = (SharedInt)behaviorTree.GetVariable("PShielded");
      PShielded.Value = 0;
      
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

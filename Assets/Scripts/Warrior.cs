using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using BehaviorDesigner.Runtime;

public class Warrior : MonoBehaviour {

//public BehaviorTree behaviorTree;

	public void Attack () {
      //BossHP = (SharedInt)behaviorTree.GetVariable("BossHP");
      GlobalVars.BossHP.Value -= GlobalVars.WarriorAtk;
      //behaviorTree.SetVariableValue("BossHP", value);
      
	}
    
}

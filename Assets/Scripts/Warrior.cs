using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using BehaviorDesigner.Runtime;

public class Warrior : MonoBehaviour {

//public BehaviorTree behaviorTree;
   //behaviorTree.SetVariableValue("BossHP", value);
    //BossHP = (SharedInt)behaviorTree.GetVariable("BossHP");

 public float AtkCounter = 0.0f;
 public float ShieldCounter = 0.0f;
 public float OpAtkCounter = 0.0f;
 public float RendCounter = 0.0f;
 public float WAtkCounter = 0.0f;
 public float TauntCounter = 0.0f;

 // Wish I was better with arrays
 public GameObject WarBut1;
 public GameObject WarBut2;
 public GameObject WarBut3;
 public GameObject WarBut4;
 public GameObject WarBut5;
 public GameObject WarBut6;

  void OnGUI () {
      
      // Find the buttons
      WarBut1 = GameObject.Find("Button");
      WarBut2 = GameObject.Find("Button (1)");
      WarBut3 = GameObject.Find("Button (2)");
      WarBut4 = GameObject.Find("Button (3)");
      WarBut6 = GameObject.Find("Button (4)");
      WarBut5 = GameObject.Find("Button (5)");
     
     
     // when my set time is reached
     if (AtkCounter >= GlobalVars.WarriorCooldown) {
         // show GUI Button
         WarBut1.GetComponent<Button> ().interactable = true;
         }
         
     if (AtkCounter >= GlobalVars.WarriorCooldown) {
         // show GUI Button
         WarBut1.GetComponent<Button> ().interactable = true;
         }
         
     WarBut6 = GameObject.Find("Button (5)");
     // add time to counter
     // use myCounter++; (same as myCounter+=1;) to count the frames - or
     AtkCounter += Time.deltaTime;
     
     if (GlobalVars.OppAtk.Value == 1) {
         WarBut2.GetComponent<Button> ().interactable = true;
     }
     
     else
     {
         WarBut2.GetComponent<Button> ().interactable = false;
     } 
     
  }

	public void Attack () {
     
      GlobalVars.BossHP.Value -= GlobalVars.WarriorAtk;
      WarBut1.GetComponent<Button> ().interactable = false;
      AtkCounter = 0.0f;
      
	}
    
    public void OpAttack () {
     
      GlobalVars.BossHP.Value -= (GlobalVars.WarriorAtk * GlobalVars.OppMod);
      WarBut2.GetComponent<Button> ().interactable = false;
      OpAtkCounter = 0.0f;
      
	}
    
    public void Rend () {
     
      GlobalVars.Rended = true;
      WarBut3.GetComponent<Button> ().interactable = false;
      RendCounter = 0.0f;
      
	}
    
    public void Shield () {
     
      GlobalVars.PShielded.Value = 1;
     // WarBut4.GetComponent<Button> ().interactable = false;
     // ShieldCounter = 0.0f;
      
	}
    
    public void Taunt () {
     
      GlobalVars.Taunted = true;
      WarBut5.GetComponent<Button> ().interactable = false;
      TauntCounter = 0.0f;
      
	}
    
    public void WAttack () {
     
      GlobalVars.BossHP.Value -= GlobalVars.WAttack;
     // WarBut6.GetComponent<Button> ().interactable = false;
     // WAtkCounter = 0.0f;
      
	}
    
}

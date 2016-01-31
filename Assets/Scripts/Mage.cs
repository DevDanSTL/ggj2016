using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using BehaviorDesigner.Runtime;

public class Mage : MonoBehaviour {

 public float FirCounter = 0.0f;
 public float IceCounter = 0.0f;
 public float InvisCounter = 0.0f;
 public float EmpCounter = 0.0f;
 public float VeilCounter = 0.0f;

 // Wish I was better with arrays
 public GameObject MagBut1;
 public GameObject MagBut2;
 public GameObject MagBut3;
 public GameObject MagBut4;
 public GameObject MagBut5;
 public GameObject MagBut6;
 public GameObject MagBut7;
 public GameObject MagBut8;

  void OnGUI () {
      
      // Find the buttons
      MagBut1 = GameObject.Find("MButton");
      MagBut2 = GameObject.Find("MButton (1)");
      MagBut3 = GameObject.Find("MButton (3)");
      MagBut4 = GameObject.Find("MButton (4)");
      MagBut5 = GameObject.Find("MButton (5)");
      MagBut6 = GameObject.Find("MButton (6)");
      MagBut7 = GameObject.Find("MButton (7)");
      MagBut8 = GameObject.Find("MButton (8)");
     
     
     // when my set time is reached
     if (FirCounter >= GlobalVars.MageCooldown) {
         // show GUI Button
         MagBut1.GetComponent<Button> ().interactable = true;
         }
         
     if (IceCounter >= GlobalVars.MageCooldown) {
         // show GUI Button
         MagBut3.GetComponent<Button> ().interactable = true;
         }
         
     // add time to counter
     // use myCounter++; (same as myCounter+=1;) to count the frames - or
     FirCounter += Time.deltaTime;
     IceCounter += Time.deltaTime;
     
  }

	public void Fireball () {
     
      GlobalVars.BossHP.Value -= GlobalVars.WarriorAtk;
      MagBut1.GetComponent<Button> ().interactable = false;
      FirCounter = 0.0f;
      
	}
    
    public void Invisibility () {
     
      GlobalVars.BossHP.Value -= (GlobalVars.WarriorAtk * GlobalVars.OppMod);
      MagBut2.GetComponent<Button> ().interactable = false;
      InvisCounter = 0.0f;
      
	}
    
    public void FrostNova () {
     
      GlobalVars.Rended = true;
      MagBut3.GetComponent<Button> ().interactable = false;
      IceCounter = 0.0f;
      
	}
    
    public void Empower () {
     
      GlobalVars.PShielded.Value = 1;
     // WarBut4.GetComponent<Button> ().interactable = false;
     // ShieldCounter = 0.0f;
      
	}
    
    public void WVeil () {
     
      GlobalVars.Taunted = true;
      MagBut5.GetComponent<Button> ().interactable = false;
      EmpCounter = 0.0f;
      
	}
    
    public void MVeil () {
     
      GlobalVars.BossHP.Value -= GlobalVars.WAttack;
     // WarBut6.GetComponent<Button> ().interactable = false;
     // WAtkCounter = 0.0f;
      
	}
    
}

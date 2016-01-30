using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using BehaviorDesigner.Runtime;

public class WarriorGUI : MonoBehaviour
{
    // public static int BossHP;        // The player's score.

    Text text;                      // Reference to the Text component.

    void Awake ()
    {
        // Set up the reference.
        text = GetComponent <Text> ();
        
        // Reset the score.
        // BossHP = 0;
    }

    void Update ()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "HP: " + GlobalVars.WarriorHP.Value;
    }
}
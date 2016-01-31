using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using BehaviorDesigner.Runtime;

public class EndUpdate : MonoBehaviour
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
        
        if (GlobalVars.BossHP.Value <= 0)
        {
            text.text = "Crushed It!";
        }
        else
        {
            text.text = "Stupid Pugs!";
        }
        
    }
}
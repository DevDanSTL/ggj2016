using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using BehaviorDesigner.Runtime;

public class Pug : MonoBehaviour
{
    // public static int BossHP;        // The player's score.
    
    public Image imgPug;

    void Awake ()
    {

    }

    void Update ()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        
        if (GlobalVars.BossHP.Value <= 0)
        {
            
        }
        else
        {
           imgPug.enabled = true;
        }
        
    }
}
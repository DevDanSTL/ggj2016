using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class returnToStart : MonoBehaviour {

	public void reStart () {
     
      SceneManager.LoadScene("DansTest");
      
    }
    
    public void quit () {

    Application.Quit(); 
             
    }
      

}
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MHealthBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
    Image image = GetComponent<Image>();
    
    image.fillAmount = (GlobalVars.MageHP.Value/100f);
    
	}
}

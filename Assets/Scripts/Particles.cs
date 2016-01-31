using UnityEngine;
using System.Collections;

public class Particles : MonoBehaviour {

public ParticleSystem firepart;

	// Use this for initialization
	void Start () {
        
    firepart.Stop();
     
    //firepart = gameObject.GetComponent<ParticleSystem>();
        //firepart.enableEmission = false;
    
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

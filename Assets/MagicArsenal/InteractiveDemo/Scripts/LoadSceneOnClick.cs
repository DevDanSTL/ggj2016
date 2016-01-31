using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LoadSceneOnClick : MonoBehaviour
{
    public void LoadScene1()  {
		Application.LoadLevel ("magic_projectiles");
	}
    public void LoadScene2()  {
		Application.LoadLevel ("magic_sprays");
	}
    public void LoadScene3()  {
		Application.LoadLevel ("magic_aura");
	}
    public void LoadScene4()  {
		Application.LoadLevel ("magic_modular");
	}
    public void LoadScene5()  {
		Application.LoadLevel ("magic_domes");
	}
    public void LoadScene6()  {
		Application.LoadLevel ("magic_shields");
	}
    public void LoadScene7()  {
		Application.LoadLevel ("magic_sphereblast");
	}
    public void LoadScene8()  {
        Application.LoadLevel("magic_enchant");
    }

}

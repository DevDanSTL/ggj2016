using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class TestMagePlayer : NetworkBehaviour {

	[SyncVar]
	public int hp = 100;

	[SyncVar]
	public int atk = 5;

	[SyncVar]
	public int aggro = 0;

	[SyncVar]
	public bool shielded = false;

	// Use this for initialization
	void Start () {

	}

	[Server]
	public void TakeDamage(int amount)
	{
		this.hp -= amount;
	}

	[Command]
	public void CmdAttackBoss()
	{
		TestBoss.Instance.TakeDamage(atk);
		Debug.Log("Mage attacked the boss");
	}

	[ClientCallback] // Only happens on the client.
	void Update () {
		if (isLocalPlayer)
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				CmdAttackBoss();
			}
		}
	}
}
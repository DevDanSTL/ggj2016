using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class TestNetBehaviour : NetworkBehaviour {

    public override void OnStartServer()
    {
        // disable client stuff
        Debug.Log("SERVER STARTED!");
    }

    public override void OnStartClient()
    {
        // register client events, enable effects
        Debug.Log("CLIENT STARTED");

    }
}

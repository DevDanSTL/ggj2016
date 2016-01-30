using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.Networking.Types;
using UnityEngine.Networking.Match;
using System.Collections.Generic;

// TODO: Determine if we need a relay server http://docs.unity3d.com/Manual/UNetInternetServicesOverview.html
public class NetworkMatchController : MonoBehaviour {

    public GameObject initialPanel;
    public GameObject createdPanel;
    public GameObject joinPanel;

    public Text dungeonIdText;
    public InputField dungeonIdInputField;

    private MatchNameGenerator matchNameGenerator;

    bool matchCreated;
    NetworkManager networkManager;

    void Start()
    {
        matchNameGenerator = FindObjectOfType<MatchNameGenerator>();
        networkManager = FindObjectOfType<NetworkManager>();
        if (matchNameGenerator == null || networkManager == null)
        {
            Debug.LogError("Failed to find dependencies! Cannot proceed to find games.");
        }
        networkManager.StartMatchMaker();
        initialPanel.SetActive(true);
        createdPanel.SetActive(false);
        joinPanel.SetActive(false);
    }

    public void CreateMatch()
    {
        string generatedName = matchNameGenerator.GenerateMatchName();
        dungeonIdText.text = generatedName;

        initialPanel.SetActive(false);
        createdPanel.SetActive(true);

        CreateMatchRequest create = new CreateMatchRequest();
        create.name = generatedName;
        create.size = 4;
        create.advertise = false;
        create.password = "";

        networkManager.matchMaker.CreateMatch(create, networkManager.OnMatchCreate);
    }

    public void FindMatch()
    {
        initialPanel.SetActive(false);
        joinPanel.SetActive(true);
    }

    public void JoinMatch()
    {
        // Bypass the network manager on this callback...
        networkManager.matchMaker.ListMatches(0, 20, dungeonIdInputField.text.ToLower().Trim(), OnMatchList);
    }

    // ---------------------------
    // Handlers:
    // ---------------------------

    public void OnMatchList(ListMatchResponse matchListResponse)
    {
        // For good measure let the network manager know...
        networkManager.OnMatchList(matchListResponse);
        if (matchListResponse.success && matchListResponse.matches != null)
        {
            networkManager.matchMaker.JoinMatch(matchListResponse.matches[0].networkId, "", networkManager.OnMatchJoined);
        }
    }
}

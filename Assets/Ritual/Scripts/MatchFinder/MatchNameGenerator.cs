using UnityEngine;
using System.Collections.Generic;

public class MatchNameGenerator : MonoBehaviour {

    public List<string> adjectives = new List<string>() {
        "angry",
        "nasty",
        "slow",
        "ginger",
        "silly",
        "slippery"
    };

    public List<string> nouns = new List<string>() {
        "chicken",
        "banana",
        "tree",
        "cup",
        "matchbox"
    };

    public int min = 1;
    public int max = 999;

    // Use this for initialization
    void Start () {
	
	}
	
	public string GenerateMatchName()
    {
        int adj = Random.Range(0, adjectives.Count);
        int noun = Random.Range(0, nouns.Count);
        int num = Random.Range(min, max);

        return adjectives[adj] + nouns[noun] + num;
    }
}

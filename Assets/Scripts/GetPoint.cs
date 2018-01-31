using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPoint : MonoBehaviour {

    private GameState theGame;
	// Use this for initialization
	void Start () {
        theGame = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameState>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            theGame.points++;
        }
    }
}

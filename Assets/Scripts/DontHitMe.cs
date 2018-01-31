using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontHitMe : MonoBehaviour {

    private GameStuff theGame;
    
    // Use this for initialization
	void Start () {
        theGame = GameObject.FindGameObjectWithTag("Bird").GetComponent<GameStuff>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        theGame.state = 2;
    }
}

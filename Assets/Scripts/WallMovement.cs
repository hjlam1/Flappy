using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour {

    private GameStuff theGame;
    
    // Use this for initialization
	void Start () {
        theGame = GameObject.FindGameObjectWithTag("Bird").GetComponent<GameStuff>();

	}
	
	// Update is called once per frame
	void Update () {
        if (theGame.state == 1)
        {
            this.transform.position = new Vector3(this.transform.position.x - theGame.speed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour {

    private GameState theGame;
    private float range;

    // Use this for initialization
	void Start () {
        range = 1.0f;
        transform.position = new Vector3 (transform.position.x, Random.Range(-range, range), transform.position.z);
        theGame = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameState>();
	}
	
	// Update is called once per frame
	void Update () {
		if (theGame.state == 1)
        {
            transform.position += Vector3.left * theGame.pace * Time.deltaTime;
            if (transform.position.x <= -10.0f)
            {
                
                if (range < 3.0f)
                {
                    range += 0.5f;
                }
                transform.position = new Vector3( 15.0f, Random.Range(-range, range), transform.position.z);
            }
        }
        

	}
    
}

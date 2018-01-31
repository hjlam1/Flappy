using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdStuff : MonoBehaviour {

    private float flyAmount;
    private Rigidbody birdBody;
    private GameStuff theGame;

	void Start () {
        birdBody = this.GetComponent<Rigidbody>();
        flyAmount = 5000.0f;
        theGame = GameObject.FindGameObjectWithTag("Bird").GetComponent<GameStuff>();
    }
	
	
	void Update () {
        if (theGame.state == 0)
        {
            birdBody.isKinematic = true;
        }
        if (theGame.state == 1)
        {
            birdBody.isKinematic = false;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                birdBody.velocity = new Vector3(0f, 0f, 0f);
                birdBody.AddForce(new Vector3(0f, 1.0f, 0f) * flyAmount * Time.deltaTime);
            }
        }
        if (theGame.state == 2)
        {
            birdBody.isKinematic = true;
        }
        
	}
}

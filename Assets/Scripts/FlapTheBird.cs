using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapTheBird : MonoBehaviour {

    public GameState theGame;
    private float jumpAmount = 200.0f;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (theGame.state == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                this.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
                this.GetComponent<Rigidbody>().AddForce(0f, jumpAmount, 0f);
            }
        }
        if (theGame.state == 2)
        {
            this.GetComponent<Rigidbody>().isKinematic = true;
        }
	}
}

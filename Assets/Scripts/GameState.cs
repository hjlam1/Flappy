using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {

    public int state;
    private GameObject theBird;
    public float pace;
    public int points;
    public TextMesh theScoreBoard;
    
    // Use this for initialization
	void Start () {
        points = 0;
        state = 0;
        pace = 1.0f;
        theBird = GameObject.FindGameObjectWithTag("Player");
        theBird.GetComponent<Rigidbody>().useGravity = false;
        Physics.gravity = new Vector3(0f, -15f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
        if (state == 1)
        {
            theScoreBoard.text = points.ToString();
            pace = 1.0f + (points / 10.0f);
        }
		
        if ((theBird.transform.position.y <= -4.5f) || (theBird.transform.position.y >= 9.5f))
        {
            state = 2;
        }

	}

    private void OnGUI()
    {
        if (state == 0)
        {

            if (GUI.Button(new Rect(140, 140, 150, 30), "Click to Start"))
            {
                state = 1;
                theBird.transform.position = new Vector3(0f, 1f, 0f);
                theBird.GetComponent<Rigidbody>().useGravity = true;
            }
        }

        if (state == 2)
        {
            if (GUI.Button(new Rect(140, 140, 100, 30), "Restart"))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

   
}

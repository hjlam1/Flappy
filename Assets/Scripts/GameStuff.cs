using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStuff : MonoBehaviour {

    public float speed;
    public int state;
   
    // Use this for initialization
	void Start () {
        speed = 1.0f;
        state = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if (state == 0 )
        {
            if (GUI.Button(new Rect(140, 140, 150, 30), "Click to Start"))
            {
                state = 1;

            }
        }

        if (state == 2)
        {
            if (GUI.Button(new Rect(140, 140, 150, 30), "Restart"))
            {
                SceneManager.LoadScene(0);

            }
        }
    }
}

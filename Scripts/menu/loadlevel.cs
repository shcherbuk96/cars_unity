using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadlevel : MonoBehaviour {
    public static int score=0;
    public Text scores;
	// Use this for initialization
	void Start () {
        uiManager.gameover = true;
        scores.text = "Best Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play() {
        Application.LoadLevel("main");
    }
}

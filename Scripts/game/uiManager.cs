﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {
    public static bool gameover = true;
    public Text scoreT;
    private int score;
	// Use this for initialization
	void Start () {
        score = 0;
        if (gameover)
        {
            InvokeRepeating("setScore", 1.0f, 0.5f);

        }
    }
	
	// Update is called once per frame
	void Update () {
        if (loadlevel.score <= score)
        {
            loadlevel.score = score;
        }
        if (gameover)
        {
            scoreT.text = "Score: " + score;
        }

	}
    void setScore()
    {
        score += 1;
       
    }
    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }else if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
}

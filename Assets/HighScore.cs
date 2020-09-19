﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    // Remember, we need t
public class HighScore : MonoBehaviour {
    static public int    score = 1000;
    void Awake() {                             
        // If the PlayerPrefs HighScore already
        if (PlayerPrefs.HasKey("HighScore")) {
            score = PlayerPrefs.GetInt("HighScore");
        }
        // Assign the high score to HighScore
        PlayerPrefs.SetInt("HighScore", score);
    }
    void Update () {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: "+score;
        // Update the PlayerPrefs HighScore if 
        if (score > PlayerPrefs.GetInt("HighScore")){
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
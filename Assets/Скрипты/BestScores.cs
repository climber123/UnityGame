using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScores : MonoBehaviour {

    private Text best_scores;
    int n;
	// Use this for initialization
	void Start () {
        n = PlayerPrefs.GetInt("Scores");
        best_scores = GetComponent<Text>();
        ShowBestScore();
	}
	public void ShowBestScore()
    {
        if (n != 0)
            best_scores.text = "Best Score: " + n; 
    }
	// Update is called once per frame
	void Update () {
    }
}

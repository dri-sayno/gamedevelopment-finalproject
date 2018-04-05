using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour {

    public Text scoreText;
    public Text highscoreText;
    public static float scoreCount;
    public static float highscoreCount;
    public float pointPerSecond;
    public static bool scoreIncreasing = true;
    public GameObject deathMenu;

	// Use this for initialization
	void Start () {
        scoreCount = 0;
        scoreIncreasing = true;
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highscoreCount = PlayerPrefs.GetFloat("HighScore");
        }
        deathMenu.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (scoreIncreasing)
        {
            scoreCount += pointPerSecond * Time.deltaTime;
        }

        if (scoreCount > highscoreCount) {
            highscoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", highscoreCount);
        }

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        highscoreText.text = "High Score: " + Mathf.Round(highscoreCount);
	}

    public static void AddScore(int pointsToAdd) {
        scoreCount += pointsToAdd;
    }
}

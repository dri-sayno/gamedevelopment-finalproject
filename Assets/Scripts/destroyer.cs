using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyer : MonoBehaviour
{
    public static float delayTime = 3f;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Egg")
        {
            if (scoremanager.scoreCount > scoremanager.highscoreCount)
            {
                scoremanager.highscoreCount = scoremanager.scoreCount;
            }
            scoremanager.scoreIncreasing = false;
            Invoke("LoadScene", delayTime);
        }
    }
    void LoadScene()
    {
        platform.ctr = 0;
        SceneManager.LoadScene(1);
    }
}

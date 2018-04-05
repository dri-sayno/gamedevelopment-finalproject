using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pausemenu : MonoBehaviour {

    public GameObject pauseMenuButton;
    public Text musicText;

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
    public void QuitToMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void PauseGame() {
        Time.timeScale = 0f;
        pauseMenuButton.SetActive(true);
    }
    public void ResumeGame() {
        Time.timeScale = 1f;
        pauseMenuButton.SetActive(false);
    }
    public void MuteSound() {
        if (musicText.text == "Music: on")
        {
            AudioListener.volume = 0f;
            musicText.text = "Music: off";
        }
        else if (musicText.text == "Music: off")
        {
            AudioListener.volume = 1f;
            musicText.text = "Music: on";
        }
    }
}

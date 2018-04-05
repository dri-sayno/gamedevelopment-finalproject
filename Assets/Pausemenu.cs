using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour {

    public GameObject pauseMenuButton;

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
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    bool gameEnded = false;
    public float restartDelay = 1F;
    public GameObject completeLevelUI;
    public GameObject GameOverUI;
    public GameObject PauseMenuUI;

    void Start() {
        Time.timeScale = 1;
    }

    public void GameOver() {
        Invoke("EndGame", 1);
    }

    void EndGame() {
        if (gameEnded == false) {
            gameEnded = true;
            Time.timeScale = 0;
            GameOverUI.SetActive(true);
        }
    }

    public void CompleteLevel()  {
        completeLevelUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void PauseLevel()  {
        Time.timeScale = 0;
        PauseMenuUI.SetActive(true);
    }

    public void ResumeLevel()  {
        Time.timeScale = 1;
        PauseMenuUI.SetActive(false);
    }

}
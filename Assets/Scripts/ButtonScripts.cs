using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour {

    public GameManager gameManager;

    public void Pause(){
        gameManager.PauseLevel();
    }

    public void Resume(){
        gameManager.ResumeLevel(); 
    }

    public void NextLevel() {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart() {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit() {
        Application.Quit();
    }

    public void Developer() {
        Application.OpenURL("https://sanglap.cf");
    }

}

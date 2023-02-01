using UnityEngine;

public class Ending : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter() {
        gameManager.CompleteLevel();
    }
}

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelNo : MonoBehaviour
{

    public Text no;

    // Start is called before the first frame update
    void Start() {
        no.text = "Level " + SceneManager.GetActiveScene().buildIndex.ToString("0");       
    }

}

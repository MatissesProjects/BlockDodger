using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        PlayerPrefs.SetInt("lives", 5);
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.GetInt("level", 1);
        SceneManager.LoadScene(1); // SceneManager.GetActiveScene().buildIndex + 
    }
}

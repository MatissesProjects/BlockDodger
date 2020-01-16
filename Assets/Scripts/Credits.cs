using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit() 
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }

    public void RestartGame()
    {
        PlayerPrefs.SetInt("lives", 5);
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.GetInt("level", 1);

        SceneManager.LoadScene(1); // load the first level, 0 is the menu
    }
}

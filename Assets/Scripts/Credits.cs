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
        SceneManager.LoadScene(1); // load the first level, 0 is the menu
    }
}

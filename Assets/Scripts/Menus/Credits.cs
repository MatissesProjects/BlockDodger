using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    private void Start() {
        FindObjectOfType<AudioManager>().Stop("Theme");
    }
    
    public void Quit() 
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }

    public void RestartGame()
    {
        FindObjectOfType<GameManager>().StartGame();
    }
}

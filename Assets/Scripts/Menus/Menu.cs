using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        FindObjectOfType<GameManager>().StartGame();
    }
}

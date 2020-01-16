using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    bool gameHasEnded = false;
    public GameObject completeLevelUI;
    public Text scoreText;

    public void Death(string audioToPlay)
    {
        if (gameHasEnded == false) 
        {
            FindObjectOfType<AudioManager>().Play(audioToPlay);

            gameHasEnded = true;

            Debug.Log("You lost a life");
            // we can do anothing here, restart the game, open a menu, show high scores, etc
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        int lives = PlayerPrefs.GetInt("lives");
        Debug.Log("number of lives left");
        Debug.Log(lives - 1);
        if (lives - 1 > 0) 
        {
            PlayerPrefs.SetInt("lives", lives - 1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        } 
        else 
        {
            SceneManager.LoadScene("Credits"); // might want to do the high score screen instead
        }
    }

    public void CompleteLevel()
    {
        PlayerPrefs.SetInt("score", int.Parse(scoreText.text));
        completeLevelUI.SetActive(true);
    }
}

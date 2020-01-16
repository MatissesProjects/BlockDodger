using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HudManager : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text livesText;
    public Text levelText;
    public Text currentSpeedText;

    // Update is called once per frame
    void Update()
    {
        livesText.text = PlayerPrefs.GetInt("lives").ToString();
        scoreText.text = Mathf.Max(player.position.z, 0).ToString("0");
        levelText.text = SceneManager.GetActiveScene().buildIndex.ToString("0");
        currentSpeedText.text = Mathf.RoundToInt(player.GetComponent<PlayerMovement>().forwardSpeed).ToString("0");
        // if we pass an obsticle we want to increase the score by 1
    }
}

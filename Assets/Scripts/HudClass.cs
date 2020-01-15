using UnityEngine;
using UnityEngine.UI;

public class HudClass : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text livesText;

    // Update is called once per frame
    void Update()
    {
        livesText.text = PlayerPrefs.GetInt("lives").ToString();
        scoreText.text = Mathf.Max(player.position.z, 0).ToString("0");
        // if we pass an obsticle we want to increase the score by 1
    }
}

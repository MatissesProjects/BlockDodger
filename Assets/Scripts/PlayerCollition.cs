using UnityEngine;

public class PlayerCollition : MonoBehaviour
{
    public PlayerMovement movement;
    private void OnCollisionEnter(Collision other) {
        if(other.collider.tag == "Obstacle") 
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

using UnityEngine;

public class SpeedPowerUp : PowerUp
{
    public float speedMultiplier = 1.5f;

    private void Start() {
        duration = 5f; // we can set powerup specific variables here
    }

    public override void ApplyPowerup(Collider player)
    {
        PlayerMovement playerMovement = player.GetComponent<PlayerMovement>();
        playerMovement.levelSpeedMultiplier *= speedMultiplier;
    }

    public override void UnapplyPowerup(Collider player)
    {
        PlayerMovement playerMovement = player.GetComponent<PlayerMovement>();
        playerMovement.levelSpeedMultiplier /= speedMultiplier;
    }

}

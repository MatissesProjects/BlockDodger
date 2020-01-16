using UnityEngine;

public class SizePowerUp : PowerUp
{
    public float sizeMultiplier = .5f;

    private void Start() {
        duration = 5f; // we can set powerup specific variables here
    }

    public override void ApplyPowerup(Collider player)
    {
        player.transform.localScale *= sizeMultiplier;
    }

    public override void UnapplyPowerup(Collider player)
    {
        player.transform.localScale /= sizeMultiplier;
    }

}

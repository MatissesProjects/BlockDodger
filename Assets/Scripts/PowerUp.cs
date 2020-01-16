using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float speedMultiplier = 1.5f;
    public float duration = 5f;

    public GameObject speedMultiplierPickupEffect;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            StartCoroutine( Pickup(other) );
        }
    }

    IEnumerator Pickup(Collider player) {
        // show cool effect on the powerup, show the speed multiplier effect
        Instantiate(speedMultiplierPickupEffect, transform.position, transform.rotation);
        
        // add in the powerup
        PlayerMovement playerMovement = player.GetComponent<PlayerMovement>();
        playerMovement.levelSpeedMultiplier *= speedMultiplier;

        // hide the object, and remove colliders
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        // wait for the duration to remove the effects
        yield return new WaitForSeconds(duration);

        // remove powerup        
        playerMovement.levelSpeedMultiplier /= speedMultiplier;

        Destroy(gameObject);
    }
}

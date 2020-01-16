using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    public float duration = 5f; // default duration for powerups

    public GameObject pickupEffect;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            StartCoroutine( Pickup(other) );
        }
    }

    IEnumerator Pickup(Collider player) {
        // show cool effect on the powerup, show the speed multiplier effect
        Instantiate(pickupEffect, transform.position, transform.rotation);
        
        // add in the powerup
        ApplyPowerup(player);

        // hide the object, and remove colliders
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        // wait for the duration to remove the effects
        yield return new WaitForSeconds(duration);

        // remove powerup        
        UnapplyPowerup(player);

        Destroy(gameObject);
    }

    public abstract void ApplyPowerup(Collider player);
    public abstract void UnapplyPowerup(Collider player);
}

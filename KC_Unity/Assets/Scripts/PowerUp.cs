/*
 * This is a sample script to create a power up!
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public GameObject pickupEffect;
    public float multiplier = 4.4f;
    public float duration = 2f;

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other)); // use coroutine to allow to pause and wait of a function
        }
    }

    IEnumerator Pickup (Collider player) // change function type to IEnumerator
    {
        Debug.Log("Power up picked up!");
        // Spawn a cool effect
        Instantiate(pickupEffect, transform.position, transform.rotation);

        // Apply effect to the player
        player.transform.localScale *= multiplier;

        // Ensure power up object removed while reversing the effect on player
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false; 

        // Wait x amount of time (secs)
        yield return new WaitForSeconds(duration);

        // Reverse the effect on our player
        player.transform.localScale /= multiplier;

        // Remove power up object
        Destroy(gameObject);
    }
}

/*
 * This is a sample script to create a power up!
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public GameObject pickupEffect;
    public float multiplier = 2.4f;


    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup (Collider player)
    {
        Debug.Log("Power up picked up!");
        // Spawn a cool effect
        Instantiate(pickupEffect, transform.position, transform.rotation);

        // Apply effect to the player
        player.transform.localScale *= multiplier;

        // Remove power up object
        Destroy(gameObject);
    }
}

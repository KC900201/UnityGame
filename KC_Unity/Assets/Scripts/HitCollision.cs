/*This script is to enable hit collision during player movement*/
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class HitCollision : MonoBehaviour
{
    public PlayerMovement movement; // a reference to our player movement script

    void OnCollisionEnter (Collision collisionInfo) // gather information about collision
    {   // check using tags instead of name for easy checking a group objects under 1 tag, name is individual
        if (collisionInfo.collider.tag == ("Obstacle")) 
        {
            Debug.Log("Hit " + collisionInfo.collider.name);
            movement.enabled = false; // disable our player movement script if object is hit
        }
    }

}

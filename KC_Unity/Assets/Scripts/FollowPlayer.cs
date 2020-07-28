/*
 * Script to enable camera follow
 */
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; // store 3 floats, vector of an object (x, y z)

    /* Not needed
    // Start is called before the first frame update
    void Start()
    {
        
    }
    */
    /*
     * Purpose:to enable camera snap to position of player object each frame
     */
    // Update is called once per frame
    void Update()
    {
//        Debug.Log(player.position);
        // transform -> transform of current object (camera)
        transform.position = player.position + offset; // Feed the position of the player object to camera
    }
}

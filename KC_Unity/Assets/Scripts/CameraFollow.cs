/*
 * Script that enables camera follow object in any angle
 */
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f; // use to control lock on speed of camera, higher value, faster to lock on target (player)
    public Vector3 offset; // to offset camera on 3 axes (x, y, z)

//    void LateUpdate() // run right after update function (after target set its movement)
    void FixedUpdate() 
    {
        Vector3 desiredPosition = target.position + offset; // to prevent camera lose track of target
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothPosition;

        transform.LookAt(target); // to fix camera always look at target (player)
    }
}

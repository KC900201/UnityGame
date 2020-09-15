/*
 * This Script is used to control player (mesh agent) 
 * movement during navigation in mesh surface
 */
using UnityEngine;
using UnityEngine.AI; // library for controlling agents
using UnityStandardAssets.Characters.ThirdPerson; //library for character animation

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character;

    // Start function
    void Start()
    {
        agent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Move our agent
                agent.SetDestination(hit.point);
            }
        }

        // control character movement
        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false); // velocity, crouch, jump
        } else
        {
            character.Move(Vector3.zero, false, false);
        }

    }
}

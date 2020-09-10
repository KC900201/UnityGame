/*
 * This Script is used to control player (mesh agent) 
 * movement during navigation in mesh surface
 */
using UnityEngine;
using UnityEngine.AI; // library for controlling agents

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;

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
        
    }
}

//using System.Collections;
//using System.Collections.Generic; //Not used
using UnityEngine;

// C-sharp language
public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 200f;
    public float dirForce = 500f;

    // Start is called before the first frame update
    // Function is called for initialization
    void Start()
    {
//        Debug.Log("Hahahaha");
//        rb.useGravity = false;
        rb.AddForce(0, 200, 550); // function arguments, need to add parameters (x, y, z)
    }

    // Update is called once per frame
    /*
    void Update()
    {
        rb.AddForce(0, 0, 200 * Time.deltaTime);   
    }
    */
    // We  used FixedUpdate() as it is much better to alter physics
    // when using Unity
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Add a fixed amount of force each frame per sec of the PC

        if (Input.GetKey("d"))
        {
            rb.AddForce(dirForce * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-dirForce * Time.deltaTime, 0, 0);
        }
    }

}

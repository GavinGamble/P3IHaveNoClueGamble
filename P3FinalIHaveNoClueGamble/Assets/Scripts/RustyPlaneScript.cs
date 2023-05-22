using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RustyPlaneScript : MonoBehaviour
{
    public GameObject plane;
    public Rigidbody rb;
    public float thrust = 100f;
    public GameObject propeller;

    void Update()
    {

        if (Input.GetKey("left"))
        {
            plane.transform.Rotate(0, 0, 1, Space.World);
        }
        if (Input.GetKey("right"))
        {
            plane.transform.Rotate(0, 0, -1, Space.World);
        }
        if (Input.GetKey("space"))
        {
            rb.AddForce(transform.forward * thrust);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
        if (Input.GetKey("down"))
        {
            plane.transform.Rotate(-1, 0, 0, Space.World);
        }
        if (Input.GetKey("up"))
        {
            plane.transform.Rotate(1, 0, 0, Space.World);
        }
    }
}
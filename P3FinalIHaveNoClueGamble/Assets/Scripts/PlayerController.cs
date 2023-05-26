using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 50f;
    public float verticalInput;
    public float rotationSpeed = 45.0f;
    public float horizontalInput;
    public float UpSpeed = 7f;
    public bool Grounded = true;
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime * verticalInput);
            Debug.Log("Left Is Working");
            //Stay The Same
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime * verticalInput);
            Debug.Log("Right Is Working");
            //Stay the Same 
        }
     //  if (Input.GetKey(KeyCode.Mouse0))
     // {
     //     transform.Rotate(0, -5, 0);
     //      Debug.Log("Q(Rotate) is working");
     //Dont Need
     //   }
     //   if (Input.GetKey(KeyCode.Mouse1))
     //   {
     //       transform.Rotate(0, 5, 0);
     //      Debug.Log("E(Rotate) is working");
     //Dont Need
     //}

        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.Translate(Vector3.up * UpSpeed * Time.deltaTime);
            Debug.Log("Forward Is Working");
            //Go forward and Up
                //Make Mouse0
        }
        // Add Tilt Up & Down
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * UpSpeed * Time.deltaTime);
            Debug.Log("Up Is Working");

            GetComponent<Rigidbody>().useGravity = false;
            //Go vertically up
        }
        else
        {
            GetComponent<Rigidbody>().useGravity = true;
        }




    }
    public void OnColliderEnter(Collider collider)
    {

    }
}


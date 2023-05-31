using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{

    public float speed = 50f;
    public float verticalInput;
    public float rotationSpeed = 45.0f;
    public float horizontalInput;
    public float UpSpeed = 7f;
    public bool Grounded = true;
    //public float xRange = 500;
    //public float zRange = 500;

    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime * verticalInput);
            transform.Rotate(0, -2, 0);
            Debug.Log("Left Is Working");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime * verticalInput);
               transform.Rotate(0, 2, 0);
            Debug.Log("Right Is Working");
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.Rotate(-3, 0, 0);
            Debug.Log("Q(Rotate) is working");
        }
         if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.Rotate(3, 0 , 0);
            Debug.Log("Rotate Down Is Working");
        }

        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.Translate(Vector3.up * UpSpeed * Time.deltaTime);
            Debug.Log("Forward Is Working");
        }

        if (Input.GetKey(KeyCode.Space))  
        {
           transform.Translate(Vector3.up * UpSpeed * Time.deltaTime);
            Debug.Log("Up Is Working");

            GetComponent<Rigidbody>().useGravity = false;
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

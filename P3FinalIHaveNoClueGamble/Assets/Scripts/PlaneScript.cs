using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{

    public float speed = 50f;
    public float verticalInput;
    public float rotationSpeed = 45.0f;
    public float horizontalInput;
    public float UpSpeed = 2f;
    public bool Grounded = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime * verticalInput);
            Debug.Log("Left Is Working");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime * verticalInput);
            Debug.Log("Right Is Working");
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -5, 0);
            Debug.Log("Q(Rotate) is working");
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 5, 0);
            Debug.Log("E(Rotate) is working");
        }

        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
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

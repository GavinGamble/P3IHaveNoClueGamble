using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RustyPlaneScript : MonoBehaviour
{

    public float speed = 50f;
    public float verticalInput;
    public float rotationSpeed = 45.0f;
    public float horizontalInput;
    public float UpSpeed = 25f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime * verticalInput);
            Debug.Log("Left Is Working");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime * verticalInput);
            Debug.Log("Right Is Working");
        }

        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Debug.Log("Forward Is Working");
        }

        if (Input.GetKey(KeyCode.Keypad0))
        {
            transform.Translate(Vector3.up * UpSpeed * Time.deltaTime);
            Debug.Log("Up Is Working");

            GetComponent<Rigidbody>().useGravity = false;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    
    public float speed = 50f;
    public float verticalInput;
    public float rotationSpeed = 45.0f;
    public float horizontalInput;
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
        }
       
       if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime * verticalInput);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            

        }
        
    }  
}

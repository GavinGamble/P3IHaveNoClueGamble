using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    private float propeller;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetKey(KeyCode.W))
        {
          propeller = Input.GetAxis("Vertical");
          transform.Rotate(Vector3.up * 40 * propeller);
        }
        if (Input.GetKey(KeyCode.Space))
        {
           propeller = Input.GetAxis("Vertical");
           transform.Rotate(Vector3.up * 40 * propeller);
        }
    }
    

}

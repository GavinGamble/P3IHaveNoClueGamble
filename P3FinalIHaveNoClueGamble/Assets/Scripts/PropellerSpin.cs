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
     
        //transform.Rotate(Vector3.up * 40 * propeller );
     if (Input.GetKey(KeyCode.Mouse0))
     {
             propeller = Input.GetAxis("Vertical");
                transform.Rotate(Vector3.up * 40 * propeller);
     }

    }
    

}

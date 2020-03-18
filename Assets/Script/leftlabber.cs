using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftlabber : MonoBehaviour
{
    Rigidbody rig;

    float power = 100;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            rig.AddForce(Vector3.up * power, ForceMode.Impulse);
           
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            rig.AddForce(Vector3.up * 0, ForceMode.Impulse);
        }
    }
  
       
        

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightlabber : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Slash))
        {
           rig.AddForce(Vector3.up * power, ForceMode.Force);
            // StartCoroutine(comeback());
        }

        if(Input.GetKeyUp(KeyCode.Slash))
        {
           rig.AddForce(Vector3.up * 0, ForceMode.Impulse);
        }
    }

      
       

    

}

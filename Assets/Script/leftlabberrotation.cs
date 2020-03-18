using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftlabberrotation : MonoBehaviour
{

    Transform tr;
    Rigidbody rig;
    Quaternion targetRotate = Quaternion.Euler(Vector3.up);


    float power = 30f;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        rig = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {

        rig.MoveRotation(Quaternion.Slerp(tr.rotation, targetRotate, 40f * Time.deltaTime));

       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            targetRotate = Quaternion.Euler(Vector3.forward * power);
            
        }

        if(Input.GetKeyUp(KeyCode.Z))
        {

           targetRotate = Quaternion.Euler(-Vector3.forward * 0);
        }

    }

  

        
    
}

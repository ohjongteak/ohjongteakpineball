using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightlabberroatation : MonoBehaviour
{
    // Start is called before the first frame update
    Transform tr;
    Rigidbody rig;
    Quaternion targetRotate = Quaternion.Euler(Vector3.zero);


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
        if (Input.GetKeyDown(KeyCode.Slash))
        {
            targetRotate = Quaternion.Euler(-Vector3.forward * power);
 
        }

        if (Input.GetKeyUp(KeyCode.Slash))
        {

            targetRotate = Quaternion.Euler(Vector3.forward * 0);
        }

    }
}

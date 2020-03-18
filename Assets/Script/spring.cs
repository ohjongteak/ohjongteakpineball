using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spring : MonoBehaviour
{
    Rigidbody rig;
    Transform tr;
    float power = 3f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKeyUp(KeyCode.Space))
        {
            rig.MovePosition(tr.position + tr.up * power);
            StartCoroutine("comeback");
        }
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            power += 3 * Time.deltaTime ;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log(power);
        }
    }

    IEnumerator comeback()
    {
       
        yield return new WaitForSeconds(0.1f);
        power = 0;
    }
    
   
  

}



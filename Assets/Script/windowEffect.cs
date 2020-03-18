using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowEffect : MonoBehaviour
{
    Transform tr;

    float power = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            this.transform.position = new Vector3(tr.position.x + power, tr.position.y + power, tr.position.z);
            StartCoroutine("comeback");
        }
        
    }
    IEnumerator comeback()
    {
        yield return new WaitForSeconds(0.1f);
        this.transform.position = new Vector3(tr.position.x - power, tr.position.y - power, tr.position.z);
    }
}

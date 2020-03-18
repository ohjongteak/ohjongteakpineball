using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioscripts : MonoBehaviour
{

    private AudioSource theA;

    public AudioClip[] Clip;

    public int [] effectsonglist;

   
    // Start is called before the first frame update
    void Start()
    {
        theA = GetComponent<AudioSource>();
    }
   
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Slash))
        {
            theA.clip = Clip[effectsonglist[0]];
            theA.PlayOneShot(Clip[effectsonglist[0]]);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            theA.clip = Clip[effectsonglist[0]];
            theA.PlayOneShot(Clip[effectsonglist[0]]);

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            theA.clip = Clip[effectsonglist[1]];
            theA.PlayOneShot(Clip[effectsonglist[1]]);
        }

    }
}

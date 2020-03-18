using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallControl : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public Transform tr;
    public GameObject Bounceb;
    public GameObject Bouncec;
    public GameObject Bounced;
    public GameObject Bouncef;
    public GameObject Bounceg;
    float x2;
    float y2;
    public Text ScoreText;
    float score = 0;

    float up = 0;
    float up2 = 0;
    float up3 = 0;
    float up4 = 0;
    float up5 = 0;

    public GameObject Thunder;
    public GameObject Yellow;
    public GameObject Teleport;
    public GameObject purplebox;
    public GameObject verysmall;

    private AudioSource Theballsong;
    public AudioClip[] Clip;
   
    private void FixedUpdate()
    {
       
        Theballsong = GetComponent<AudioSource>();
        Physics.gravity = new Vector3(0, -40.0f, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bounceB"))
        {
            //Vector3 dir = tr.position - Bounceb.transform.position;
          
            x2 = tr.position.x - Bounceb.transform.position.x;
            y2 = tr.position.y - Bounceb.transform.position.y;
            x2 = x2 * 5;
            y2 = y2 * 5;
            score += 15;
            Theballsong.clip = Clip[0];
            Theballsong.PlayOneShot(Clip[0]);
            Yellow.gameObject.SetActive(true);
            StartCoroutine("yellowscore");
            this.gameObject.GetComponent<Rigidbody>().AddForce(x2, y2 ,tr.position.z, ForceMode.Impulse);
        }

        if (collision.gameObject.CompareTag("bounceC"))
        {

            x2 = tr.position.x - Bouncec.transform.position.x;
            y2 = tr.position.y - Bouncec.transform.position.y;
            x2 = x2 * 2;
            y2 = y2 * 2;
            score += 30;
            Theballsong.clip = Clip[0];
            Theballsong.PlayOneShot(Clip[0]);
            purplebox.gameObject.SetActive(true);
            StartCoroutine("PurpleScore");
            this.gameObject.GetComponent<Rigidbody>().AddForce(x2, y2, tr.position.z, ForceMode.Impulse);
        }

        if (collision.gameObject.CompareTag("bounceD"))
        {

            x2 = tr.position.x - Bounced.transform.position.x;
            y2 = tr.position.y - Bounced.transform.position.y;
            x2 = x2 * 15;
            y2 = y2 * 15;
            score += 5;
            Theballsong.clip = Clip[0];
            Theballsong.PlayOneShot(Clip[0]);
            Thunder.gameObject.SetActive(true);
            StartCoroutine("Thunderscore");
            this.gameObject.GetComponent<Rigidbody>().AddForce(x2, y2, tr.position.z, ForceMode.Impulse);
        }

        if (collision.gameObject.CompareTag("bounceF"))
        {
            x2 = tr.position.x - Bounced.transform.position.x;
            y2 = tr.position.y - Bounced.transform.position.y;
            x2 = x2 * 1.5f;
            y2 = y2 * 1.5f;
            score += 25;
            Theballsong.clip = Clip[0];
            Theballsong.PlayOneShot(Clip[0]);
            verysmall.gameObject.SetActive(true);
            StartCoroutine("VerysmallScore");
            this.gameObject.GetComponent<Rigidbody>().AddForce(x2, y2, tr.position.z, ForceMode.Impulse);

        }

        if (collision.gameObject.CompareTag("bounceG"))
        {
            score += 50;
            Theballsong.clip = Clip[1];
            Theballsong.PlayOneShot(Clip[1]);
            Teleport.gameObject.SetActive(true);
            StartCoroutine("TelePortScore");
            tr.transform.position = new Vector3(-0.3f, 102, -0.7f);

        }
        ScoreText.text = " "+score;

    }

    IEnumerator yellowscore()
    {
        Yellow.transform.position = new Vector3(Yellow.transform.position.x, Yellow.transform.position.y - up);
        up = 0;
        up += 0.5f;
        yield return new WaitForSeconds(0.2f);
        Yellow.transform.position = new Vector3(Yellow.transform.position.x, Yellow.transform.position.y + 0.5f);
        up += 0.5f;
        yield return new WaitForSeconds(0.2f);
        Yellow.transform.position = new Vector3(Yellow.transform.position.x, Yellow.transform.position.y + 0.5f);
        up += 0.5f;
        yield return new WaitForSeconds(0.2f);
        Yellow.transform.position = new Vector3(Yellow.transform.position.x, Yellow.transform.position.y + 0.5f);
        yield return new WaitForSeconds(0.2f);
        Yellow.gameObject.SetActive(false);
    }

    IEnumerator Thunderscore()
    {
        Thunder.transform.position = new Vector3(Thunder.transform.position.x, Thunder.transform.position.y - up2);
        up2 = 0;
        up2 += 0.5f;
        yield return new WaitForSeconds(0.2f);
        Thunder.transform.position = new Vector3(Thunder.transform.position.x, Thunder.transform.position.y + 0.5f);
        up2 += 0.5f;
        yield return new WaitForSeconds(0.2f);
        Thunder.transform.position = new Vector3(Thunder.transform.position.x, Thunder.transform.position.y + 0.5f);
        up2 += 0.5f;
        yield return new WaitForSeconds(0.2f);
        Thunder.transform.position = new Vector3(Thunder.transform.position.x, Thunder.transform.position.y + 0.5f);
        yield return new WaitForSeconds(0.2f);
        Thunder.gameObject.SetActive(false);
    }


    IEnumerator PurpleScore()
    {
        purplebox.transform.position = new Vector3(purplebox.transform.position.x, purplebox.transform.position.y - up3);
        up3 = 0;
        up3 += 0.5f;
        yield return new WaitForSeconds(0.2f);
        purplebox.transform.position = new Vector3(purplebox.transform.position.x, purplebox.transform.position.y + 0.5f);
        up3 += 0.5f;
        yield return new WaitForSeconds(0.2f);
        purplebox.transform.position = new Vector3(purplebox.transform.position.x, purplebox.transform.position.y + 0.5f);
        up3 += 0.5f;
        yield return new WaitForSeconds(0.2f);
        purplebox.transform.position = new Vector3(purplebox.transform.position.x, purplebox.transform.position.y + 0.5f);
        yield return new WaitForSeconds(0.2f);
        purplebox.gameObject.SetActive(false);
    }

    IEnumerator VerysmallScore()
    {
       verysmall.transform.position = new Vector3(verysmall.transform.position.x, verysmall.transform.position.y - up4);
        up4 = 0;
        up4 += 0.5f;
        yield return new WaitForSeconds(0.2f);
        verysmall.transform.position = new Vector3(verysmall.transform.position.x, verysmall.transform.position.y + 0.5f);
        up4 += 0.5f;
        yield return new WaitForSeconds(0.2f);
        verysmall.transform.position = new Vector3(verysmall.transform.position.x, verysmall.transform.position.y + 0.5f);
        up4 += 0.5f;
        yield return new WaitForSeconds(0.2f);
        verysmall.transform.position = new Vector3(verysmall.transform.position.x, verysmall.transform.position.y + 0.5f);
        yield return new WaitForSeconds(0.2f);
        verysmall.gameObject.SetActive(false);
    }

    IEnumerator TelePortScore()
    {
        Teleport.transform.position = new Vector3(Teleport.transform.position.x, Teleport.transform.position.y - up5);
        up5 = 0;
        up5 += 0.5f;
        yield return new WaitForSeconds(0.2f);
        Teleport.transform.position = new Vector3(Teleport.transform.position.x, Teleport.transform.position.y + 0.5f);
        up5 += 0.5f;
        yield return new WaitForSeconds(0.2f);
        Teleport.transform.position = new Vector3(Teleport.transform.position.x, Teleport.transform.position.y + 0.5f);
        up5 += 0.5f;
        yield return new WaitForSeconds(0.2f);
        Teleport.transform.position = new Vector3(Teleport.transform.position.x, Teleport.transform.position.y + 0.5f);
        yield return new WaitForSeconds(0.2f);
        Teleport.gameObject.SetActive(false);
    }


}

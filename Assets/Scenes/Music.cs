using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip SE1;
    public AudioClip SE2;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Falls2")
        {
            audioSource.PlayOneShot(SE1);
        }

        if (collision.gameObject.tag == "Falls3")
        {
            audioSource.PlayOneShot(SE1);
        }

        if (collision.gameObject.tag == "Falls1")
        {
            audioSource.PlayOneShot(SE2);
        }
    }
}
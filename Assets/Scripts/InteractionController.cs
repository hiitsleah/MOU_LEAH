using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
#if UNITY_WEBGL && !UNITY_EDITOR
        lookSpeed *= .65f;
#endif

public class InteractionController : MonoBehaviour
{
    public GameObject sign1;
    public GameObject fog;

    public AudioClip[] clips; // [] means it is an array, of multiple things
    private AudioSource audioSource;



    //public AudioClip music;

    //public GameObject piclight;
    //public AudioClip panelClose;
    //AudioSource audioSrc;

    void Start()
    {
        sign1.SetActive(false);
        fog.SetActive(true);

        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;

        //piclight.SetActive(false);
        //audioSrc = GetComponent<AudioSource>();
    }


    private AudioClip GetRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Entered");
            sign1.SetActive(true);
            fog.SetActive(false);


            //if (!audioSource.isPlaying)
            //{
                audioSource.clip = GetRandomClip();
                audioSource.Play();
            //}

            if (Input.GetKeyDown("3"))
            {
                audioSource.clip = GetRandomClip();
                audioSource.Play();
            }


            //audioSrc.PlayOneShot(music);

            //piclight.SetActive(true);
            //audioSrc(panelOpen);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //fog.SetActive(true);
            sign1.SetActive(false);

            audioSource.Stop();

            //piclight.SetActive(false);
            Debug.Log("Player Exited");
            ////        sign1.SetActive(false);
            ////        pic1.SetActive(false);
            ////        audioSrc.PlayOneShot(panelClose);
        }
    }

}
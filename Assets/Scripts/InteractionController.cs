using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
public class InteractionController : MonoBehaviour
{
    public GameObject musicMenu;
    public GameObject fog;
    public AudioClip music;

    //public GameObject piclight;
    //public AudioClip panelClose;
    AudioSource audioSrc;

    void Start()
    {
        musicMenu.SetActive(false);
        fog.SetActive(true);

        //piclight.SetActive(false);
        audioSrc = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Entered");
            musicMenu.SetActive(true);
            fog.SetActive(false);

            //piclight.SetActive(true);
            //audioSrc(panelOpen);
        }
    }

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        fog.SetActive(true);

    //        //piclight.SetActive(false);
    //        Debug.Log("Player Exited");
    //        ////        sign1.SetActive(false);
    //        ////        pic1.SetActive(false);
    //        ////        audioSrc.PlayOneShot(panelClose);
    //    }
    //}

}
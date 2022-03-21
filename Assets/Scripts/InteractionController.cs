using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
public class InteractionController : MonoBehaviour
{
    public GameObject sign1;
    public GameObject Rain;
    public AudioClip panelOpen;
    //public GameObject piclight;
    //public AudioClip panelClose;
    AudioSource audioSrc;

    void Start()
    {
        sign1.SetActive(false);
        
        Rain.SetActive(true);
        //piclight.SetActive(false);
        audioSrc = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Entered");
            sign1.SetActive(true);
            Rain.SetActive(false);
            //piclight.SetActive(true);
            //audioSrc(panelOpen);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Rain.SetActive(true);
            //piclight.SetActive(false);
            Debug.Log("Player Exited");
            ////        sign1.SetActive(false);
            ////        pic1.SetActive(false);
            ////        audioSrc.PlayOneShot(panelClose);
        }
    }

}
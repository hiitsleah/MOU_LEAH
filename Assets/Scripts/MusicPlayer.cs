using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] clips; // [] means it is an array, of multiple things
    private AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = false;

    }

    private AudioClip GetRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }


    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
        }

        if (Input.GetKeyDown("3"))
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeCollider : MonoBehaviour
{
    public GameObject narrativeText;
    public GameObject avatar;


    void Start()
    {
        narrativeText.SetActive(false);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Entered");
            narrativeText.SetActive(true);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoamCollider : MonoBehaviour
{
    public GameObject roamText;


    void Start()
    {
        roamText.SetActive(false);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Entered");
            roamText.SetActive(true);
            
        }
    }

    
}

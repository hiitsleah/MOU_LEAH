using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeCollider : MonoBehaviour
{
    public GameObject narrativeText;
    public GameObject avatar;
    //public GameObject lookUp;


    void Start()
    {
        narrativeText.SetActive(false);
        avatar.SetActive(false);
        //lookUp.SetActive(false);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Entered");
            narrativeText.SetActive(true);
            avatar.SetActive(true);
            //lookUp.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            narrativeText.SetActive(false);
            avatar.SetActive(false);
            //lookUp.SetActive(false);

        }
    }
}

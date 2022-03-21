using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadMeController : MonoBehaviour
{
    public GameObject readMe;


    void Start()
    {
        readMe.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            readMe.SetActive(true);
        }

        if (Input.GetKeyDown("1"))
        {
            readMe.SetActive(false);
        }
    }
}

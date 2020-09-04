using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource source;
    public GameObject aliens;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (aliens.transform.childCount <= 5)
        {
            source.pitch = 1.8f;

        }
        else if (aliens.transform.childCount <= 8)
        {
            source.pitch = 1.5f;

        }

        else if (aliens.transform.childCount <= 12)
        {
            source.pitch = 1.2f;

        }




    }
}

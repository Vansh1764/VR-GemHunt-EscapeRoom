using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boilingPot : MonoBehaviour
{
    private AudioSource audioSource;

    void start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OntriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(audioSource != null)
            {
                audioSource.Play();
            }
        }
    }


    private void OntriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(audioSource != null)
            {
                audioSource.Stop();
            }
        }
    }
}


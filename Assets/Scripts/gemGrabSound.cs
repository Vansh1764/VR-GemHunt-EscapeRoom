using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class gemGrabSound : MonoBehaviour
{
    private AudioSource gemAudioSource;

    void start()
    {
        gemAudioSource = GetComponent<AudioSource>();
    }

    // public void OnSelectEnter(XRBaseInteractor interactor)
    // {
    //     gemAudioSource.Play();
    // }

    public void OnSelectEnter()
    {
        Debug.Log("Sound should play");
        if (gemAudioSource != null)
        {
            gemAudioSource.Play();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Speak_Fireman : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource.clip == null)
        {
            Debug.LogError("No audio clip assigned to Speak_Fireman on GameObject: " + gameObject.name);
            return;
        }

        PlayAudio();
    }

    public void PlayAudio()
    {
        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }
    }
}


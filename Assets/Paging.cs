using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paging : MonoBehaviour
{
    [Header("Audio")]

    public AudioClip spawnSound;

    [Header("Page")]

    public List<GameObject> items;

    public void OnSummon(string[] values)
    {
        int i = 0;
        if (values[0] == "page")
        {
            if (values[1] == "one")
            {
                i = 0;
            }
            else if (values[1] == "two")
            {
                i = 1;
            }
            else if (values[1] == "three")
            {
                i = 2;
        }
        else
            print("Not Working");

        AudioPlay();
        items[i].SetActive(true);
    }


        AudioPlay();
        items[i].SetActive(false);
    }
    private void AudioPlay()
    {
        if (spawnSound != null)
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
            audioSource.clip = spawnSound;
            audioSource.Play();
        }
    }
}


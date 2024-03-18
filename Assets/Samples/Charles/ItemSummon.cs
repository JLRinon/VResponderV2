using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSummon : MonoBehaviour
{
    [Header("Audio")]

    public AudioClip spawnSound;

    [Header("Items")]

    public List<GameObject> items;

    public void OnSummon(string[] values)
    {
        int i = 0;
        if (values[0] == "get")
        {
            if (values[1] == "flashlight")
            {
                i = 1;
            }
            else if (values[1] == "c-collar")
            {
                i = 2;
            }
            else if (values[1] == "stethoscope")
            {
                i = 3;
            }
            else if (values[1] == "thermometer")
            {
                i = 4;
            }
            else if (values[1] == "sphygmomanometer")
            {
                i = 5;
            }
            else if (values[1] == "spinal board")
            {
                i = 6;
            }
            else if (values[1] == "extrication device")
            {
                i = 7;
            }
            else
            {
                print("Item not available");
            }
        }
        else
            print("Not Working");

        AudioPlay();
        items[i].SetActive(true);
    }

    public void OnDeSummon(string[] values)
    {
        int i = 0;
        if (values[0] == "return")
        {
            if (values[1] == "flashlight")
            {
                i = 1;
            }
            else if (values[1] == "c-collar")
            {
                i = 2;
            }
            else if (values[1] == "stethoscope")
            {
                i = 3;
            }
            else if (values[1] == "thermometer")
            {
                i = 4;
            }
            else if (values[1] == "sphygmomanometer")
            {
                i = 5;
            }
            else if (values[1] == "spinal board")
            {
                i = 6;
            }
            else if (values[1] == "extrication device")
            {
                i = 7;
            }
            else
            {
                print("Item not available");
            }
        }
        else
            print("Not Working");

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

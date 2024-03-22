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
        int i = -1; // Initialize i to an invalid index

        if (values[0] == "get")
        {
            switch (values[1])
            {
                case "flashlight":
                    i = 0; break;
                case "c-collar":
                    i = 1; break;
                case "stethoscope":
                    i = 2; break;
                case "thermometer":
                    i = 3; break;
                case "sphygmomanometer":
                    i = 4; break;
                case "spinal board":
                    i = 5; break;
                case "extrication device":
                    i = 6; break;
                default:
                    print("Item not available");
                    break;
            }
        }
        else
        {
            print("Not Working");
            return;
        }

        if (i != -1 && i < items.Count)
        {
            AudioPlay();
            items[i].SetActive(true);
        }
    }

    public void OnDeSummon(string[] values)
    {
        int i = -1; // Initialize i to an invalid index

        if (values[0] == "return")
        {
            switch (values[1])
            {
                case "flashlight":
                    i = 0; break;
                case "c-collar":
                    i = 1; break;
                case "stethoscope":
                    i = 2; break;
                case "thermometer":
                    i = 3; break;
                case "sphygmomanometer":
                    i = 4; break;
                case "spinal board":
                    i = 5; break;
                case "extrication device":
                    i = 6; break;
                default:
                    print("Item not available");
                    break;
            }
        }
        else
        {
            print("Not Working");
            return;
        }

        if (i != -1 && i < items.Count)
        {
            AudioPlay();
            items[i].SetActive(false);
        }
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

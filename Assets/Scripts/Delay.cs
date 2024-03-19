using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public float delayTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = audioClip;
        StartCoroutine(PlayDelayedAudio(delayTime));
    }

    // Update is called once per frame
    private IEnumerator PlayDelayedAudio(float delay)
    {
        yield return new WaitForSeconds(delay);
        audioSource.Play();
    }
}

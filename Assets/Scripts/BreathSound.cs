using UnityEngine;

public class BreathSound : MonoBehaviour
{
    public AudioClip breathSound; // Drag and drop the breath sound clip in the Inspector
    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component from the GameObject
        audioSource = GetComponent<AudioSource>();

        // Assign the breath sound clip to the AudioSource
        audioSource.clip = breathSound;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Check if the breath sound clip is assigned
            if (breathSound != null)
            {
                // Play the breath sound clip
                audioSource.Play();
                Debug.Log("Breath sound is now playing.");
            }
            else
            {
                Debug.LogError("No breath sound clip assigned. Drag and drop a breath sound clip in the Inspector.");
            }
        }
    }

    public void StopBreathSound()
    {
        // Stop the breath sound clip
        audioSource.Stop();
        Debug.Log("Breath sound stopped.");
    }

    // Check if the audio is playing
    private void Update()
    {
        if (audioSource.isPlaying)
        {
            Debug.Log("Breath sound is still playing.");
        }
    }
}

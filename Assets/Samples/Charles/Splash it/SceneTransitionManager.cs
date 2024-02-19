using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransitionManager : MonoBehaviour
{
    public Image fadeImage;
    public GameObject loadingImage;
    public float fadeDuration = 3f; // Default duration for fading transition

    private void Start()
    {
        // Ensure the fade image is initially disabled
        fadeImage.enabled = false;
        loadingImage.SetActive(false);
    }

    public void LoadScene(string sceneName)
    {
        StartCoroutine(Transition(sceneName));
    }

    IEnumerator Transition(string sceneName)
    {
        // Fade out
        fadeImage.enabled = true;
        fadeImage.CrossFadeAlpha(1, fadeDuration, false);

        // Show loading image with animation
        loadingImage.SetActive(true);
        // Add your animation logic here

        // Wait for the fade out to complete
        yield return new WaitForSeconds(fadeDuration);

        // Load the new scene asynchronously
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);

        // Wait until the new scene is fully loaded
        while (!asyncOperation.isDone)
        {
            yield return null;
        }

        // Hide loading image
        loadingImage.SetActive(false);

        // Fade in
        fadeImage.CrossFadeAlpha(0, fadeDuration, false);

        // Wait for the fade in to complete
        yield return new WaitForSeconds(fadeDuration);

        // Ensure the fade image is disabled after fading
        fadeImage.enabled = false;
    }
}

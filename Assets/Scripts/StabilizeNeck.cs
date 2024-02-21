using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class StabilizeNeck : MonoBehaviour
{
    public Animator animator;
    public InputActionReference activationInput;
    public float activationDelay = 1f; // Default delay is 1 second
    private bool isActivated = false;

    private void OnEnable()
    {
        StartCoroutine(EnableActivationInputWithDelay());
    }

    private void OnDisable()
    {
        activationInput.action.Disable();
    }

    private IEnumerator EnableActivationInputWithDelay()
    {
        yield return new WaitForSeconds(activationDelay);
        activationInput.action.Enable();
        activationInput.action.started += OnActivationInput;
    }

    private void OnActivationInput(InputAction.CallbackContext context)
    {
        // Toggle activation state for each input
        isActivated = !isActivated;

        // Log activation state
        Debug.Log("Activation Input Detected. Activation State: " + isActivated);

        // Set animator parameter based on activation state
        animator.SetBool("Activate", isActivated);
    }
}

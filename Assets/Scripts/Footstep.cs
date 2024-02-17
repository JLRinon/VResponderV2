using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Footstep : MonoBehaviour
{
    public InputActionProperty leftHandMoveButton, rightHandMoveButton;
    public AudioSource footStepSound;
    void Update()
    {
        if (leftHandMoveButton.action.ReadValue<Vector2>().magnitude > 0.1f || rightHandMoveButton.action.ReadValue<Vector2>().magnitude > 0.1f)
        {
            footStepSound.enabled = true;
        }
        else
        {
            footStepSound.enabled=false;
        }
    }
}

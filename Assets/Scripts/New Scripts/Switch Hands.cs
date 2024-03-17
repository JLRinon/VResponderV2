using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SwitchHands : MonoBehaviour
{
    XRGrabInteractable grabInteractable;
    [SerializeField]
    Transform leftHandAttach;
    [SerializeField]
    Transform rightHandAttach;
    [SerializeField]
    GameObject leftHandInteractor;
    [SerializeField]
    GameObject rightHandInteractor;

    Transform lastAttachedTransform;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        lastAttachedTransform = rightHandAttach; // Set default attach transform
    }

    public void SwapHands()
    {
        Debug.Log("SwapHands called");
        if (grabInteractable.selectingInteractor != null)
        {
            GameObject selectingInteractor = grabInteractable.selectingInteractor.gameObject;

            Debug.Log("Last Attached Transform: " + lastAttachedTransform.name);
            Debug.Log("Selecting Interactor: " + selectingInteractor.name);

            if (lastAttachedTransform == leftHandAttach && selectingInteractor == rightHandInteractor)
            {
                // If the object was previously attached to the left hand and the right hand is selecting it now,
                // switch attach transform to right hand attach
                grabInteractable.attachTransform = rightHandAttach;
                lastAttachedTransform = rightHandAttach;
            }
            else if (lastAttachedTransform == rightHandAttach && selectingInteractor == leftHandInteractor)
            {
                // If the object was previously attached to the right hand and the left hand is selecting it now,
                // switch attach transform to left hand attach
                grabInteractable.attachTransform = leftHandAttach;
                lastAttachedTransform = leftHandAttach;
            }

            Debug.Log("New Attached Transform: " + grabInteractable.attachTransform.name);
        }
    }
}

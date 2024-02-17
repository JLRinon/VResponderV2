using UnityEngine;
using UnityEngine.Events;

public class ActivateOnCollision : MonoBehaviour
{
    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;

    bool hasTriggered = false;

    void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered)
        {
            onTriggerEnter.Invoke();
            hasTriggered = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        onTriggerExit.Invoke();
    }
}

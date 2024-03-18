using UnityEngine;
using UnityEngine.Events;

public class ActivateDeactivateOnCollision : MonoBehaviour
{
    [SerializeField] UnityEvent onPlayerEnter;
    [SerializeField] UnityEvent onPlayerExit;

    [SerializeField] GameObject[] objectsToActivate;
    [SerializeField] GameObject[] objectsToDeactivate;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ActivateObjects();
            onPlayerEnter.Invoke();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DeactivateObjects();
            onPlayerExit.Invoke();
        }
    }

    void ActivateObjects()
    {
        foreach (GameObject obj in objectsToActivate)
        {
            obj.SetActive(true);
        }

        foreach (GameObject obj in objectsToDeactivate)
        {
            obj.SetActive(false);
        }
    }

    void DeactivateObjects()
    {
        foreach (GameObject obj in objectsToActivate)
        {
            obj.SetActive(false);
        }

        foreach (GameObject obj in objectsToDeactivate)
        {
            obj.SetActive(true);
        }
    }
}

using UnityEngine;
using UnityEngine.Events;

public class SandbagCollision : MonoBehaviour
{
    [SerializeField] UnityEvent onSandbagEnter;
    [SerializeField] UnityEvent onSandbagExit;

    [SerializeField] GameObject[] objectsToActivate;
    [SerializeField] GameObject[] objectsToDeactivate;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sandbag"))
        {
            ActivateObjects();
            onSandbagEnter.Invoke();
        }
    }

    void OnTriggerExit(Collider other)
    {
        DeactivateObjects();
        onSandbagExit.Invoke();
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

using UnityEngine;

public class ActivateOnAllActive : MonoBehaviour
{
    public GameObject[] objectsToMonitor;
    public GameObject objectToActivate;
    public GameObject[] objectsToDeactivate;
    public GameObject[] additionalObjectsToActivate;

    private bool[] objectStates;

    private void Start()
    {
        objectStates = new bool[objectsToMonitor.Length];
        for (int i = 0; i < objectStates.Length; i++)
        {
            objectStates[i] = objectsToMonitor[i].activeSelf;
        }
    }

    private void Update()
    {
        bool allActive = true;
        for (int i = 0; i < objectsToMonitor.Length; i++)
        {
            if (!objectsToMonitor[i].activeSelf)
            {
                allActive = false;
                break;
            }
        }

        if (allActive)
        {
            objectToActivate.SetActive(true);
            for (int i = 0; i < objectsToDeactivate.Length; i++)
            {
                objectsToDeactivate[i].SetActive(false);
            }
            for (int i = 0; i < additionalObjectsToActivate.Length; i++)
            {
                additionalObjectsToActivate[i].SetActive(true);
            }
        }
        else
        {
            objectToActivate.SetActive(false);
        }
    }
}

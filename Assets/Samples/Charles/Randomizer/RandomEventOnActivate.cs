using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class RandomEventOnActivate : MonoBehaviour
{
    [System.Serializable]
    public struct EventScenario
    {
        public UnityEvent scenarioEvent;
        public GameObject[] scenarioGameObjects;
    }

    [SerializeField] List<EventScenario> eventScenarios = new List<EventScenario>();

    void OnEnable()
    {
        PlayRandomScenario();
    }

    void PlayRandomScenario()
    {
        if (eventScenarios.Count == 0)
        {
            Debug.LogWarning("No event scenarios specified.");
            return;
        }

        int randomIndex = Random.Range(0, eventScenarios.Count);
        EventScenario randomScenario = eventScenarios[randomIndex];

        // Activate random game objects for the selected scenario
        foreach (GameObject obj in randomScenario.scenarioGameObjects)
        {
            if (obj != null)
                obj.SetActive(true);
        }

        // Invoke the Unity Event of the selected scenario
        if (randomScenario.scenarioEvent != null)
            randomScenario.scenarioEvent.Invoke();
    }
}

using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using TMPro;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class PA2Counter : MonoBehaviour
{
    public float counterPA2 = 100f;
    public float itemEquivalent = 0f;
    public GameObject activate;
    public GameObject deactivate;
    public TextMeshProUGUI textMeshPro;
    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering object is one of the objects you want to count
        if (other.CompareTag("Counter"))
        {
            counterPA2 -= itemEquivalent;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the exiting object is one of the objects you want to count
        if (other.CompareTag("Counter"))
        {
            counterPA2 += itemEquivalent;
        }
    }

    private void Update()
    {
        Debug.Log(counterPA2.ToString());
        float value = counterPA2;
        textMeshPro.text = "Your Score for this assessment is " + value + "% you may now proceed.";

        if (counterPA2 <= 50f) 
        {
            activate.SetActive(true);
            deactivate.SetActive(false);
        }
        else if (counterPA2 > 50f)
        {
            deactivate.SetActive(true);
            activate.SetActive(false);
        }
    }
}
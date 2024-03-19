using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class PA2Counter : MonoBehaviour
{
    public float counterPA2 = 100f;
    public float itemEquivalent = 0f;
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
    }
}
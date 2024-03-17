using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class ObjectCounter : MonoBehaviour
{
    private int objectCount = 5;
    public int percentScore = 100;
    public TextController textController; // Reference to TextController script
    public Canvas currentObjective;
    public List<GameObject> objectiveComplete;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering object is one of the objects you want to count
        if (other.CompareTag("CountableObject"))
        {
            objectCount--;
            percentScore -= 20;
            UpdateText();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the exiting object is one of the objects you want to count
        if (other.CompareTag("CountableObject"))
        {
            objectCount++;
            percentScore += 20;
            UpdateText();

            if(objectCount >= 3)
            {
                foreach (GameObject gameObject in objectiveComplete)
                {
                    if (gameObject != null)
                    {
                        gameObject.gameObject.SetActive(true);
                    }
                }

                if (currentObjective != null)
                {
                    currentObjective.gameObject.SetActive(false);
                }
            }
        }
    }

 

    private void UpdateText()
    {
        // Update the TextMeshPro text using your TextController
        if (textController != null)
        {
            textController.UpdateText(objectCount, 5);
        }
    }
}

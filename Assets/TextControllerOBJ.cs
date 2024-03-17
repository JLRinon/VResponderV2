using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextControllerOBJ : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public GameObject counter;
    private void Start()
    {
        ObjectCounter objectCounter = counter.GetComponent<ObjectCounter>();
        float value = objectCounter.percentScore;
        if (textMeshPro != null)
        {
            Debug.Log(value.ToString());
            textMeshPro.text = "Your score for this objective is " + value + " %" ;
        }
    }
}
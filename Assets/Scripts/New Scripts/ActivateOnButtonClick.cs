using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ActivateOnButtonClick : MonoBehaviour
{
    public GameObject gameObject;
    public Button button1;
    public Button button2;
    public UnityEvent onTrueYes;
    public UnityEvent onFalseYes;
    public UnityEvent onTrueNo;
    public UnityEvent onFalseNo;

    void Start()
    {
        // Check if the button reference is set
        if (button1 != null && button2 != null)
        {
            // Add a listener to the click event of button1
            button1.onClick.AddListener(OnButton1Click);
            button2.onClick.AddListener(OnButton2Click);
        }
        else
        {
            Debug.LogWarning("Button reference not set!");
        }
    }

    void OnButton1Click()
    {
        // Check if gameObject is active and button1 is clicked
        if (gameObject.activeSelf)
        {
            // If both conditions are met, invoke the Unity Event
            onTrueYes.Invoke();
        }

        else if (!gameObject.activeSelf)
        {
            onFalseYes.Invoke();
        }

        else
        {
            Debug.LogWarning("No Correct!!!");
        }
    }

    void OnButton2Click()
    {
        // Check if gameObject is active and button1 is clicked
        if (gameObject.activeSelf)
        {
            // If both conditions are met, invoke the Unity Event
            onFalseNo.Invoke();
        }

        else if (!gameObject.activeSelf)
        {
            onTrueNo.Invoke();
        }

        else
        {
            Debug.LogWarning("No Correct!!!");
        }
    }
}

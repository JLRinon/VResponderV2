using UnityEngine;

public class PositionLogger : MonoBehaviour
{
    public GameObject objectToTrack;

    void Update()
    {
        Debug.Log("Position: " + objectToTrack.transform.position);
    }
}

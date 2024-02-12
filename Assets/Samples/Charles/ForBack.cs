using Meta.WitAi.CallbackHandlers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForBack : MonoBehaviour
{
    public MultiValueEvent onBack = new MultiValueEvent();

    public void Back(string[] values)
    {
        if (gameObject.activeSelf && values[0] == "back")
        {
            onBack.Invoke(values);
        }

        else
            print("Not Working");
    }

}

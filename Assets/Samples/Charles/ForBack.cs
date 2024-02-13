using Meta.WitAi.CallbackHandlers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forBak : MonoBehaviour
{
    public MultiValueEvent onBak = new MultiValueEvent();

    public void Bak(string[] values)
    {
        if (gameObject.activeSelf && values[0] == "back")
        {
            onBak.Invoke(values);
        }

        else
            print("Not Working");
    }

}

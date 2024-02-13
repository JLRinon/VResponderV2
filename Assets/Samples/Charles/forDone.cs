using Meta.WitAi.CallbackHandlers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forDone : MonoBehaviour
{
    public MultiValueEvent onDone = new MultiValueEvent();

    public void Done(string[] values)
    {
        if (gameObject.activeSelf && values[0] == "next")
        {
            onDone.Invoke(values);
        }

        else
            print("Not Working");
    }

}

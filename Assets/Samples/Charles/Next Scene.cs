using Meta.WitAi.CallbackHandlers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour
{
    public MultiValueEvent onNextScene = new MultiValueEvent();

    public void sceneNext(string[] values)
    {
        if (gameObject.activeSelf && values[0] == "next")
        {
            onNextScene.Invoke(values);
        }

        else
            print("Not Working");
    }

}

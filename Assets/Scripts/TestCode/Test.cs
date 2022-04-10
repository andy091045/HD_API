using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        string gameTitle = GameSettings.Instance.gameTitle;
        string gameVersion = GameSettings.Instance.gameVersion;

        Debug.Log("You're playing " + gameTitle + " version " + gameVersion);
    }
}

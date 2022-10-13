using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] Score scoreScript;
    [SerializeField] SceneChanger sceneChangerScript;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scoreScript.AddPoints(10);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            sceneChangerScript.ChangeScenesSequentially();
        }
    }
}

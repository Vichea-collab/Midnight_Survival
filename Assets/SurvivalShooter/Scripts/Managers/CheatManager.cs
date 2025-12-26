using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class CheatManager
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Initialize()
    {
        SceneManager.activeSceneChanged += HandleActiveSceneChanged;
    }

    private static void HandleActiveSceneChanged(Scene arg0, Scene arg1)
    {
        InjectActiveScene();
    }

    private static void InjectActiveScene()
    {
        
    }
}

using UnityEngine;

public class ForceFullscreen : MonoBehaviour
{
    void Awake()
    {
        Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
        Screen.SetResolution(1920, 1080, true);
    }
}

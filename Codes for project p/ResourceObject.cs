using UnityEngine;

public class ResourceObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.runInBackground = true;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Application.targetFrameRate = 60;

        //SceneManager.LoadSceneAsync();
        //SceneManager.UnloadSceneAsync();
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public string sceneName;
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1.0f;
    }
}


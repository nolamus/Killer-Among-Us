using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public static Stack SceneHistory;
    // Load a scene using the scene name while handling general scene transitions
    
    
    // Load the previous scene stored in the Scene history
    public void LoadPreviousScene()
    {
        SceneManager.LoadScene((string)SceneHistory.Pop());
    }
    public void SaveScene(string sceneName)
    {
        SceneHistory.Push(sceneName);
    }

    public void LoadGameSceneZero()
    {
        SceneManager.LoadScene(1);
    }

    // Exits the game and hold all potential exit game transition sequences
    public void ExitGame()
    {
        SceneHistory.Clear();
        Application.Quit();
    }
}

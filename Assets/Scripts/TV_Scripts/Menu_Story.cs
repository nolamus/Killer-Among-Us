/*
 * Project: Killer Among Us
 * This script was initially created by Joseph Ene
 */
// This script is supposed to hold functions that allows for consistent scene transition processes for the project
// This will later include fade in and fade out transition timings and title cards between each killer among us level
// The script will later control which level buttons are revealed on the je_LevelSelect Scene as the player completes each level
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Story : MonoBehaviour
{
    public static Stack SceneHistory;
    // Load a scene using the scene name while handling general scene transitions


    // Load the previous scene stored in the Scene history
    public void LoadPreviousScene()
    {
        SceneManager.LoadScene((string)SceneHistory.Pop());
    }

   /*
    * Store Scene name in a stack to be used when a scene needs to reload the scene before it
    public void SaveScene(string sceneName)
    {
        SceneHistory.Push(sceneName);
    }*/

    // Load the that should be run when Level Zero is selected in je_LevelSelect
    public void LoadStoryMode()
    {
      SceneManager.LoadScene("Intro_Dialogue");

    }

    public void LoadGameSceneZero()
    {
        SceneManager.LoadScene("AA_Level_Zero.unity");
    }

    // Exits the game and hold all potential exit game transition sequences
    public void ExitGame()
    {
        SceneHistory.Clear();
        Application.Quit();
    }
}

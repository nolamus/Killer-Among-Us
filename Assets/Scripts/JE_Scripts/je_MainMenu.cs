using UnityEngine;
using UnityEngine.SceneManagement;

public class je_MainMenu : MonoBehaviour
{
    //SceneTransition transitioner;
    // Function called by main menu scene start button to transition to game scene
    public void StartGame()
    {
        //transitioner.SaveScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(1);
    }

    public void DisplaySettings()
    {
        SceneManager.LoadScene("je_Settings");
    }
    public void DisplayLevelSelect()
    {
        SceneManager.LoadScene("je_LevelSelect");
        
    }
    public void DiplayMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
        Application.Quit();
        //transitioner.ExitGame();
    }
}

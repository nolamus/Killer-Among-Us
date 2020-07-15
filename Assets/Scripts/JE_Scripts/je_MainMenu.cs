/*
 * Project: Killer Among Us 
 * This script was initially created by Joseph Ene
 */
using UnityEngine;
using UnityEngine.SceneManagement;

public class je_MainMenu : MonoBehaviour
{
    public GameObject RulesPanel;
    public GameObject CreditsPanel;
    private void Start()
    {
        RulesPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        
    }
    //SceneTransition transitioner;
    // Function called by main menu scene start button to transition to game scene
    public void StartGame()
    {
        //transitioner.SaveScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("AA_Level_Zero.unity");
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
        SceneManager.LoadScene("je_MainMenu");
    }
    public void DiplayCreditsPanel()
    {
        CreditsPanel.SetActive(true);
    }
    public void DiplayRulesPanel()
    {
        RulesPanel.SetActive(true);
    }
    public void CloseRulesPanel()
    {
        RulesPanel.SetActive(false);
    }
    public void CloseCreditsPanel()
    {
        CreditsPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
        //transitioner.ExitGame();
    }
}

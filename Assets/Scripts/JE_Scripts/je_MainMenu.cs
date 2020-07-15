/*
 * Project: Killer Among Us 
 * This script was initially created by Joseph Ene
 */
using SaveSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class je_MainMenu : MonoBehaviour
{
    public GameObject RulesPanel;
    public GameObject CreditsPanel;
    public bool Lvl0Cleared;
    public bool Lvl1Cleared;
    public bool Lvl2Cleared;
    public bool Lvl3Cleared;
    public bool Lvl4Cleared;
    public bool Lvl5Cleared;
    private void Awake()
    {
        Lvl0Cleared = EasySave.Load<bool>("Lvl0Cleared");
        Lvl1Cleared = EasySave.Load<bool>("Lvl1Cleared");
        Lvl2Cleared = EasySave.Load<bool>("Lvl2Cleared");
        Lvl3Cleared = EasySave.Load<bool>("Lvl3Cleared");
        Lvl4Cleared = EasySave.Load<bool>("Lvl4Cleared");
        Lvl5Cleared = EasySave.Load<bool>("Lvl5Cleared");
    }
    private void Start()
    {
        RulesPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        
    }
    private void OnApplicationPause(bool pause)
    {
        EasySave.Save("Lvl0Cleared",Lvl0Cleared);
        EasySave.Save("Lvl1Cleared",Lvl1Cleared);
        EasySave.Save("Lvl2Cleared",Lvl2Cleared);
        EasySave.Save("Lvl3Cleared",Lvl3Cleared);
        EasySave.Save("Lvl4Cleared",Lvl4Cleared);
        EasySave.Save("Lvl5Cleared",Lvl5Cleared);
    }
    private void OnApplicationQuit()
    {
        EasySave.Save("Lvl0Cleared", Lvl0Cleared);
        EasySave.Save("Lvl1Cleared", Lvl1Cleared);
        EasySave.Save("Lvl2Cleared", Lvl2Cleared);
        EasySave.Save("Lvl3Cleared", Lvl3Cleared);
        EasySave.Save("Lvl4Cleared", Lvl4Cleared);
        EasySave.Save("Lvl5Cleared", Lvl5Cleared);
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

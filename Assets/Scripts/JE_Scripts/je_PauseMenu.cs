using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class je_PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    // Used to perform a check on all script processing input
    // to determine what pause state it should be in
    public static bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        // Ensures pause menu is hidden on scene load
        pauseMenu.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        // Binds Pause functionality to a key
        //TODO Need to revise code to accept game standard input controls
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();

            }
            else
            {
                PauseGame();
            }
        }
        
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Settings()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("je_Settings");
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("je_MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }



    
}

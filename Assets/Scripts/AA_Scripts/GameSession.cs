using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public int lives = 5;
    [SerializeField] Text livesText;

    private void Awake()
    {
        int numberOfGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numberOfGameSessions > 1)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        livesText.text = lives.ToString();
    }

    public void ProcessPlayerDeath()
    {
        Debug.Log("Lives: " + lives);
        if(lives >= 1)
            TakeLife();
        else
            ResetGameSession();         
    }

    private void TakeLife()
    {
        lives--;
        livesText.text = lives.ToString();              
    }

    private void ResetGameSession()
    {
        SceneManager.LoadScene(5);      //loads main menu if player runs out of lives
        Destroy(gameObject);
    }
}

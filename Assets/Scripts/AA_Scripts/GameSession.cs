using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int lives = 3;
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
        if(lives > 1)
            TakeLife();
        else
            ResetGameSession();         
    }

    private void TakeLife()
    {
        lives--;
        var currentCheckPoint = SceneManager.GetActiveScene().buildIndex;
        livesText.text = lives.ToString();
        //SceneManager.LoadScene(2);
    }

    private void ResetGameSession()
    {
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }
}

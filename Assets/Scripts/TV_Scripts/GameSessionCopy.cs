using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSessionCopy : MonoBehaviour
{
  // Start is called before the first frame update
  [SerializeField] public int lives = 3;
  [SerializeField] Text livesText;
  public static bool alive = true;


  private void Awake()
  {
      int numberOfGameSessions = FindObjectsOfType<GameSessionCopy>().Length;

  /*   if (numberOfGameSessions > 1)
      {
          Destroy(gameObject);
        }
      else
          DontDestroyOnLoad(gameObject); */
  }
  void Start()
  {
      livesText.text = lives.ToString();
  }

  public void ProcessPlayerDeath()
  {
    if(!alive)
      return;

      Debug.Log("Lives: " + lives);

      if(lives > 0)
          TakeLife();
      else{
          alive = false;
          ResetGameSession();

        }
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

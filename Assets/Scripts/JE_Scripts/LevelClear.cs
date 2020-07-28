using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelClear : MonoBehaviour
{
    public GameObject Level0Button;
    public GameObject Level1Button;
    public GameObject Level2Button;
    public GameObject Level3Button;
    public GameObject Level4Button;
    public GameObject Level5Button;
    // Start is called before the first frame update
    void Start()
    {
        

        if (je_MainMenu.Lvl1Cleared)
        {
            Level1Button.SetActive(true);
        }
        else
        {
            Level1Button.SetActive(false);
        }
        if (je_MainMenu.Lvl2Cleared)
        {
            Level2Button.SetActive(true);
        }
        else
        {
            Level2Button.SetActive(false);
        }
        if (je_MainMenu.Lvl3Cleared)
        {
            Level3Button.SetActive(true);
        }
        else
        {
            Level3Button.SetActive(false);
        }
        if (je_MainMenu.Lvl4Cleared)
        {
            Level4Button.SetActive(true);
        }
        else
        {
            Level4Button.SetActive(false);
        }
        if (je_MainMenu.Lvl5Cleared)
        {
            Level5Button.SetActive(true);
        }
        else
        {
            Level5Button.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}

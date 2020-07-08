using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class je_KeyManager : MonoBehaviour
{

    public GameObject Key;
    public GameObject NotificationPanel;
    public TextMeshProUGUI ObtainedKeyMessage;
    // Start is called before the first frame update
    void Start()
    {
        NotificationPanel.SetActive(false);
        if(je_Door.RevealKey)
        {
            Key.SetActive(true);
        }
        else
        {
            Key.SetActive(false);
        }
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        je_Door.Lvl2KeyTracker++;
        Destroy(Key);
        NotificationPanel.SetActive(true);
        Destroy(NotificationPanel, 2f);
    }
}

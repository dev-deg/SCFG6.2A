using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private delegate void PauseCallbackDelegate();
    private static event PauseCallbackDelegate PAUSE_STATE_CHANGED;


    //value
    private bool _isPaused;
    
    //getters and setters
    public bool Paused
    {
        get => _isPaused;
        set
        {
            if (_isPaused != value)
            {
                _isPaused = value;
                //Triggering the PAUSE_STATE_CHANGED event
                PAUSE_STATE_CHANGED?.Invoke();
            }
        }
    }


    private Image _uiBackground;
    // Start is called before the first frame update
    void Start()
    {
        _uiBackground = GameObject.Find("Canvas").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

        }
    }
}

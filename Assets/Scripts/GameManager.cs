using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private bool _isPaused = false;

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
            if (_isPaused)
            {
                //resume
                _isPaused = false;
                _uiBackground.enabled = false;
                Time.timeScale = 1;
            }
            else
            {
                //pause
                _isPaused = true;
                _uiBackground.enabled = true;
                Time.timeScale = 0;
            }
            
        }
    }
}

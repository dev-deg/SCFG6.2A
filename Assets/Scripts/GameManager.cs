using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private delegate void PauseCallbackDelegate(bool isPaused);
    private static event PauseCallbackDelegate PAUSE_STATE_CHANGED;


    //value
    private bool _isPaused;
    
    //getters and setters
    private bool Paused
    {
        get => _isPaused;
        set
        {
            if (_isPaused != value)
            {
                _isPaused = value;
                //triggering the PAUSE_STATE_CHANGED event
                PAUSE_STATE_CHANGED?.Invoke(value);
            }
        }
    }


    private Image _uiBackground;
    // Start is called before the first frame update



    private void PauseChangeListener(bool isPaused)
    {
        _uiBackground.enabled = isPaused;
        if (isPaused)
        {
            Time.timeScale = 0;
            Debug.Log("Paused the Game");
        }
        else
        {
            Time.timeScale = 1;
            Debug.Log("Resumed the Game");
        }
    }

    void Awake()
    {
        PAUSE_STATE_CHANGED += PauseChangeListener;
    }

    private void OnDestroy()
    {
        PAUSE_STATE_CHANGED -= PauseChangeListener;
    }

    void Start()
    {
        _uiBackground = GameObject.Find("Canvas").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //set the current pause state to the opposite of what it currently is
            Paused = !Paused;
        }
    }
}

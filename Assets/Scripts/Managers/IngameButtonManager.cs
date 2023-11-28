using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngameButtonManager : MonoBehaviour
{
    ArduinoInput input;
    public Button playButtonGO;
    public Button quitButtonGO;
    public Button playButtonW;
    public Button quitButtonW;
    private bool navegando = false;
    GameManager gameManager;


    private void OnEnable()
    {
        input = FindObjectOfType<ArduinoInput>();
        gameManager = FindObjectOfType<GameManager>();
        navegando = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (navegando && gameManager.isGameOver)
        {
            if (input.buttonValue == 1)
            {
                playButtonGO.onClick.Invoke();
            }
            if (input.button2Value == 1)
            {
                quitButtonGO.onClick.Invoke();
            }
        }
        else if (navegando && gameManager.isCompleted)
        {
            if (input.buttonValue == 1)
            {
                playButtonW.onClick.Invoke();
            }
            if (input.button2Value == 1)
            {
                quitButtonW.onClick.Invoke();
            }
        }
    }

    private void OnDisable()
    {
        navegando = false;
    }
}

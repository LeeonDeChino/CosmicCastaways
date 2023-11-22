using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public Button continueButton;
    public Button quitButton;
    private int input;
    public ArduinoInput arduinoInput;
    private bool enPausa = false;

    private void OnEnable()
    {
        enPausa = true;
    }
    private void OnDisable()
    {
        enPausa = false;
    }
    private void Update()
    {
        if (enPausa)
        {
            input = arduinoInput.value;

            if(input == 2)
            {
                continueButton.onClick.Invoke();
            }
            if(input == 3)
            {
                quitButton.onClick.Invoke();
            }
        }
    }
}

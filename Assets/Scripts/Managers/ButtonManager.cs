using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    ArduinoInput input;
    ControllerInput controllerInput;
    public Button playButton;
    public Button quitButton;


    private void Start()
    {
        input = GetComponent<ArduinoInput>();
        controllerInput = GetComponent<ControllerInput>();
    }
    // Update is called once per frame
    void Update()
    {
        if(input.buttonValue == 1 || controllerInput.boton1 == 1)
        {
            playButton.onClick.Invoke();
        }
        if (input.button2Value == 1 || controllerInput.boton2 == 1)
        {
            quitButton.onClick.Invoke();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    ArduinoInput input;
    public Button playButton;
    public Button quitButton;


    private void Start()
    {
        input = GetComponent<ArduinoInput>();
    }
    // Update is called once per frame
    void Update()
    {
        if(input.buttonValue == 1)
        {
            playButton.onClick.Invoke();
        }
        if (input.button2Value == 1)
        {
            quitButton.onClick.Invoke();
        }
    }
}

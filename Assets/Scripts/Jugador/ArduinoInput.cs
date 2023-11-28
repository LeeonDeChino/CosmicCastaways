using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoInput : MonoBehaviour
{
    public SerialPort sp = new SerialPort("COM5", 9600);
    public int joystickValue,buttonValue,button2Value,button3Value;
    public int value;

    // Start is called before the first frame update
    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }

    void FixedUpdate()
    {
        if (sp.IsOpen)
        {
            try
            {
                //ReadCom();
                Inputs();
            }
            catch (System.Exception)
            {

            }
        }
        else
        {
            Debug.Log("Is not opened");
        }
    }
    void Inputs()
    {
        string[] arrayInput = sp.ReadLine().Split(',');
        joystickValue = int.Parse(arrayInput[0]);
        buttonValue = int.Parse(arrayInput[1]);
        button2Value = int.Parse(arrayInput[2]);
        button3Value = int.Parse(arrayInput[3]);

        Debug.Log(joystickValue+","+buttonValue+ ","+button2Value + ","+button3Value);


        //Debug.Log(value);

    }

    public void CloseCom()
    {
        sp.Close();
    }
}

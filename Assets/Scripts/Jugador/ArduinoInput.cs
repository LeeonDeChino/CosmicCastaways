using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoInput : MonoBehaviour
{
    public SerialPort sp = new SerialPort("COM4", 9600);
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
        value = int.Parse(sp.ReadLine());

        //Debug.Log(value);

    }

    public void CloseCom()
    {
        sp.Close();
    }
}
